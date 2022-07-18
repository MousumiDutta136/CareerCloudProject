using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.CompanyJobService;
namespace CareerCloud.gRPC.Services
{
    public class CompanyJobController : CompanyJobServiceBase
    {
        private readonly CompanyJobLogic _logic;

        public CompanyJobController()
        {
            _logic = new CompanyJobLogic(new EfGenericRepository<CompanyJobPoco>());
        }
        public override Task<CompanyJob> GetCompanyJob(IdRequest5 request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
            
            return new Task<CompanyJob>(() => TranslateTo(_logic.Get(id)));
        }

        public override Task<Empty> AddCompanyJob(CompanyJobs request, ServerCallContext context)
        {
            List<CompanyJobPoco> pocos = new List<CompanyJobPoco>();
            foreach (var item in request.CompJob)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateCompanyJob(CompanyJobs request, ServerCallContext context)
        {
            List<CompanyJobPoco> pocos = new List<CompanyJobPoco>();
            foreach (var item in request.CompJob)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteCompanyJob(CompanyJobs request, ServerCallContext context)
        {
            List<CompanyJobPoco> pocos = new List<CompanyJobPoco>();
            foreach (var item in request.CompJob)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<CompanyJobs> GetCompanyJobs(Empty request, ServerCallContext context)
        {
            List<CompanyJob> protos = new List<CompanyJob>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }

            CompanyJobs CompJobs = new CompanyJobs();
            CompJobs.CompJob.AddRange(protos);

            return new Task<CompanyJobs>(() => CompJobs);
        }


        private CompanyJobPoco TranslateFrom(CompanyJob proto)
        {
            return new CompanyJobPoco()
            {
                Id = Guid.Parse(proto.Id),
                Company = Guid.Parse(proto.Company),                
                ProfileCreated = proto.ProfileCreated.ToDateTime(),
                IsInactive = proto.IsInactive,
                IsCompanyHidden = proto.IsCompanyHidden
            };
        }

        private CompanyJob TranslateTo(CompanyJobPoco poco)
        {
            return new CompanyJob()
            {
                Id = poco.Id.ToString(),
                Company = poco.Company.ToString(),              
                ProfileCreated = poco.ProfileCreated == null ? null : Timestamp.FromDateTime((DateTime)poco.ProfileCreated),               
                IsInactive = poco.IsInactive

            };
        }
    }
}
