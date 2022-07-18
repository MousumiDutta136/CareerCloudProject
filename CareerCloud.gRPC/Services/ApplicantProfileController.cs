using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.ApplicantProfileService;
namespace CareerCloud.gRPC.Services
{
    public class ApplicantProfileController : ApplicantProfileServiceBase
    {
        private readonly ApplicantProfileLogic _logic;

        public ApplicantProfileController()
        {
            _logic = new ApplicantProfileLogic(new EfGenericRepository<ApplicantProfilePoco>());
        }
        public override Task<ApplicantProfile> GetApplicantProfile(IdRequest3 request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);            
            return new Task<ApplicantProfile>(() => TranslateTo(_logic.Get(id)));
        }

        public override Task<Empty> AddApplicantProfile(ApplicantProfiles request, ServerCallContext context)
        {
            List<ApplicantProfilePoco> pocos = new List<ApplicantProfilePoco>();
            foreach (var item in request.AppProfl)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateApplicantProfile(ApplicantProfiles request, ServerCallContext context)
        {
            List<ApplicantProfilePoco> pocos = new List<ApplicantProfilePoco>();
            foreach (var item in request.AppProfl)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteApplicantProfile(ApplicantProfiles request, ServerCallContext context)
        {
            List<ApplicantProfilePoco> pocos = new List<ApplicantProfilePoco>();
            foreach (var item in request.AppProfl)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<ApplicantProfiles> GetApplicantProfiles(Empty request, ServerCallContext context)
        {
            List<ApplicantProfile> protos = new List<ApplicantProfile>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }

            ApplicantProfiles AppProfls = new ApplicantProfiles();
            AppProfls.AppProfl.AddRange(protos);

            return new Task<ApplicantProfiles>(() => AppProfls);
        }


        private ApplicantProfilePoco TranslateFrom(ApplicantProfile proto)
        {
            return new ApplicantProfilePoco()
            {
                Id = Guid.Parse(proto.Id),
                Login = Guid.Parse(proto.Login),
                CurrentSalary = (decimal)proto.CurrentSalary,
                CurrentRate = (decimal)proto.CurrentRate,
                Currency = proto.Currency.ToString(),
                Country = proto.Country.ToString(),
                Province = proto.Province.ToString(),
                Street = proto.Street.ToString(),
                City = proto.City.ToString(),
                PostalCode = proto.City.ToString()
            };
        }

        private ApplicantProfile TranslateTo(ApplicantProfilePoco poco)
        {
            return new ApplicantProfile()
            {
                Id = poco.Id.ToString(),
                Login = poco.Login.ToString(),
                CurrentSalary = (double)poco.CurrentSalary,
                CurrentRate = (double)poco.CurrentRate,
                Currency = poco.Currency,
                Country = poco.Country,
                Province = poco.Province,
                Street = poco.Street,
                City = poco.City,
                PostalCode = poco.PostalCode

            };
        }
    }
}
