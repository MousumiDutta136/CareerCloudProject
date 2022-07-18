using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.SecurityLoginService;
namespace CareerCloud.gRPC.Services
{
    public class SecurityLoginController : SecurityLoginServiceBase
    {
        private readonly SecurityLoginLogic _logic;

        public SecurityLoginController()
        {
            _logic = new SecurityLoginLogic(new EfGenericRepository<SecurityLoginPoco>());
        }
        public override Task<SecurityLogin> GetSecurityLogin(IdRequest7 request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
           
            return new Task<SecurityLogin>(() => TranslateTo(_logic.Get(id)));
        }

        public override Task<Empty> AddSecurityLogin(SecurityLogins request, ServerCallContext context)
        {
            List<SecurityLoginPoco> pocos = new List<SecurityLoginPoco>();
            foreach (var item in request.SecurLogin)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateSecurityLogin(SecurityLogins request, ServerCallContext context)
        {
            List<SecurityLoginPoco> pocos = new List<SecurityLoginPoco>();
            foreach (var item in request.SecurLogin)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteSecurityLogin(SecurityLogins request, ServerCallContext context)
        {
            List<SecurityLoginPoco> pocos = new List<SecurityLoginPoco>();
            foreach (var item in request.SecurLogin)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<SecurityLogins> GetSecurityLogins(Empty request, ServerCallContext context)
        {
            List<SecurityLogin> protos = new List<SecurityLogin>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }

            SecurityLogins securLogins = new SecurityLogins();
            securLogins.SecurLogin.AddRange(protos);

            return new Task<SecurityLogins>(() => securLogins);
        }


        private SecurityLoginPoco TranslateFrom(SecurityLogin proto)
        {
            return new SecurityLoginPoco()
            {
                Id = Guid.Parse(proto.Id),
                Login = proto.Login,
                Password = proto.Password,                
                Created = proto.Created.ToDateTime(),
                PasswordUpdate = proto.PasswordUpdate.ToDateTime(),
                AgreementAccepted = proto.AgreementAccepted.ToDateTime(),
                IsLocked = proto.IsLocked,
                IsInactive = proto.IsInactive,
                EmailAddress = proto.EmailAddress,
                PhoneNumber = proto.PhoneNumber,
                FullName = proto.FullName,
                ForceChangePassword = proto.ForceChangePassword,
                PrefferredLanguage = proto.PrefferredLanguage
            };
        }

        private SecurityLogin TranslateTo(SecurityLoginPoco poco)
        {
            return new SecurityLogin()
            {
                Id = poco.Id.ToString(),
                Login = poco.Login,
                Password = poco.Password,
                Created = poco.Created == null ? null : Timestamp.FromDateTime((DateTime)poco.Created),
                PasswordUpdate = poco.PasswordUpdate == null ? null : Timestamp.FromDateTime((DateTime)poco.PasswordUpdate),
                AgreementAccepted = poco.AgreementAccepted == null ? null : Timestamp.FromDateTime((DateTime)poco.AgreementAccepted),
                IsLocked = poco.IsLocked,
                IsInactive = poco.IsInactive,
                EmailAddress = poco.EmailAddress,
                PhoneNumber = poco.PhoneNumber,
                FullName = poco.FullName,
                ForceChangePassword = poco.ForceChangePassword,
                PrefferredLanguage = poco.PrefferredLanguage
            };
        }
    }
}
