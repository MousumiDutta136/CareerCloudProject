using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.CompanyJobEducationService;
namespace CareerCloud.gRPC.Services
{
    public class CompanyJobEducationController : CompanyJobEducationServiceBase
    {
        private readonly CompanyJobEducationLogic _logic;

        public CompanyJobEducationController()
        {
            _logic = new CompanyJobEducationLogic(new EfGenericRepository<CompanyJobEducationPoco>());
        }
        public override Task<CompanyJobEducation> GetCompanyJobEducation(IdRequest6 request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
          
            return new Task<CompanyJobEducation>(() => TranslateTo(_logic.Get(id)));
        }

        public override Task<Empty> AddCompanyJobEducation(CompanyJobEducations request, ServerCallContext context)
        {
            List<CompanyJobEducationPoco> pocos = new List<CompanyJobEducationPoco>();
            foreach (var item in request.CompJobEdu)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateCompanyJobEducation(CompanyJobEducations request, ServerCallContext context)
        {
            List<CompanyJobEducationPoco> pocos = new List<CompanyJobEducationPoco>();
            foreach (var item in request.CompJobEdu)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteCompanyJobEducation(CompanyJobEducations request, ServerCallContext context)
        {
            List<CompanyJobEducationPoco> pocos = new List<CompanyJobEducationPoco>();
            foreach (var item in request.CompJobEdu)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<CompanyJobEducations> GetCompanyJobEducations(Empty request, ServerCallContext context)
        {
            List<CompanyJobEducation> protos = new List<CompanyJobEducation>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }

            CompanyJobEducations compsJobEdus = new CompanyJobEducations();
            compsJobEdus.CompJobEdu.AddRange(protos);

            return new Task<CompanyJobEducations>(() => compsJobEdus);
        }


        private CompanyJobEducationPoco TranslateFrom(CompanyJobEducation proto)
        {
            return new CompanyJobEducationPoco()
            {
                Id = Guid.Parse(proto.Id),
                Job = Guid.Parse(proto.Job),
                Major = proto.Major,
                Importance = (short)proto.Importance                
            };
        }

        private CompanyJobEducation TranslateTo(CompanyJobEducationPoco poco)
        {
            return new CompanyJobEducation()
            {
                Id = poco.Id.ToString(),
                Job = poco.Job.ToString(),
                Major = poco.Major,
                Importance = poco.Importance             

            };
        }
    }
}
