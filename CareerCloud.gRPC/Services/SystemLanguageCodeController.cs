using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.SystemLanguageCodeService;
namespace CareerCloud.gRPC.Services
{
    public class SystemLanguageCodeController : SystemLanguageCodeServiceBase
    {
        private readonly SystemLanguageCodeLogic _logic;

        public SystemLanguageCodeController()
        {
            _logic = new SystemLanguageCodeLogic(new EfGenericRepository<SystemLanguageCodePoco>());
        }
        public override Task<SystemLanguageCode> GetSystemLanguageCode(LanguIdRequest9 request, ServerCallContext context)
        {
             string id = request.LanguageID;
           
            return new Task<SystemLanguageCode>(() => TranslateTo(_logic.Get(id)));
        }

        public override Task<Empty> AddSystemLanguageCodes(SystemLanguageCodes request, ServerCallContext context)
        {
            List<SystemLanguageCodePoco> pocos = new List<SystemLanguageCodePoco>();
            foreach (var item in request.SystLangCd)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateSystemLanguageCode(SystemLanguageCodes request, ServerCallContext context)
        {
            List<SystemLanguageCodePoco> pocos = new List<SystemLanguageCodePoco>();
            foreach (var item in request.SystLangCd)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteSystemLanguageCode(SystemLanguageCodes request, ServerCallContext context)
        {
            List<SystemLanguageCodePoco> pocos = new List<SystemLanguageCodePoco>();
            foreach (var item in request.SystLangCd)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<SystemLanguageCodes> GetSystemLanguageCodes(Empty request, ServerCallContext context)
        {
            List<SystemLanguageCode> protos = new List<SystemLanguageCode>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }

            SystemLanguageCodes systLangCds = new SystemLanguageCodes();
            systLangCds.SystLangCd.AddRange(protos);

            return new Task<SystemLanguageCodes>(() => systLangCds);
        }


        private SystemLanguageCodePoco TranslateFrom(SystemLanguageCode proto)
        {
            return new SystemLanguageCodePoco()
            {
                LanguageID = proto.LanguageID,
                Name = proto.Name,
                NativeName = proto.NativeName             
            };
        }

        private SystemLanguageCode TranslateTo(SystemLanguageCodePoco poco)
        {
            return new SystemLanguageCode()
            {
                LanguageID = poco.LanguageID,
                Name = poco.Name,
                NativeName = poco.NativeName
  

            };
        }
    }
}
