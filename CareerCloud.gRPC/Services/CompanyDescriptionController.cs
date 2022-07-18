using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.CompanyDescriptionService;
namespace CareerCloud.gRPC.Services
{
    public class CompanyDescriptionController : CompanyDescriptionServiceBase
    {
        private readonly CompanyDescriptionLogic _logic;

        public CompanyDescriptionController()
        {
            _logic = new CompanyDescriptionLogic(new EfGenericRepository<CompanyDescriptionPoco>());
        }
        public override Task<CompanyDescription> GetCompanyDescription(IdRequest4 request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);           
            return new Task<CompanyDescription>(() => TranslateTo(_logic.Get(id)));
        }

        public override Task<Empty> AddCompanyDescription(CompanyDescriptions request, ServerCallContext context)
        {
            List<CompanyDescriptionPoco> pocos = new List<CompanyDescriptionPoco>();
            foreach (var item in request.CompDesc)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateCompanyDescription(CompanyDescriptions request, ServerCallContext context)
        {
            List<CompanyDescriptionPoco> pocos = new List<CompanyDescriptionPoco>();
            foreach (var item in request.CompDesc)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteCompanyDescription(CompanyDescriptions request, ServerCallContext context)
        {
            List<CompanyDescriptionPoco> pocos = new List<CompanyDescriptionPoco>();
            foreach (var item in request.CompDesc)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<CompanyDescriptions> GetCompanyDescriptions(Empty request, ServerCallContext context)
        {
            List<CompanyDescription> protos = new List<CompanyDescription>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }

            CompanyDescriptions compDescs = new CompanyDescriptions();
            compDescs.CompDesc.AddRange(protos);

            return new Task<CompanyDescriptions>(() => compDescs);
        }


        private CompanyDescriptionPoco TranslateFrom(CompanyDescription proto)
        {
            return new CompanyDescriptionPoco()
            {
                Id = Guid.Parse(proto.Id),
                Company = Guid.Parse(proto.Company),
                LanguageId = proto.LanguageId,
                CompanyName = proto.CompanyName,
                CompanyDescription = proto.CompanyDescript

            };
        }

        private CompanyDescription TranslateTo(CompanyDescriptionPoco poco)
        {
            return new CompanyDescription()
            {
                Id = poco.Id.ToString(),
                Company = poco.Company.ToString(),
                LanguageId = poco.LanguageId,
                CompanyName = poco.CompanyName,
                CompanyDescript = poco.CompanyDescription


            };
        }
    }
}
