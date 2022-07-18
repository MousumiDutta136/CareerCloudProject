using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.SecurityLoginsLogService;
namespace CareerCloud.gRPC.Services
{
    public class SecurityLoginsLogController : SecurityLoginsLogServiceBase
    {
        private readonly SecurityLoginsLogLogic _logic;

        public SecurityLoginsLogController()
        {
            _logic = new SecurityLoginsLogLogic(new EfGenericRepository<SecurityLoginsLogPoco>());
        }
        public override Task<SecurityLoginsLog> GetSecurityLoginsLog(IdRequest8 request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
            
            return new Task<SecurityLoginsLog>(() => TranslateTo(_logic.Get(id)));
        }

        public override Task<Empty> AddSecurityLoginsLogs(SecurityLoginsLogs request, ServerCallContext context)
        {
            List<SecurityLoginsLogPoco> pocos = new List<SecurityLoginsLogPoco>();
            foreach (var item in request.SecurLogin)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateSecurityLoginsLog(SecurityLoginsLogs request, ServerCallContext context)
        {
            List<SecurityLoginsLogPoco> pocos = new List<SecurityLoginsLogPoco>();
            foreach (var item in request.SecurLogin)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteSecurityLoginsLog(SecurityLoginsLogs request, ServerCallContext context)
        {
            List<SecurityLoginsLogPoco> pocos = new List<SecurityLoginsLogPoco>();
            foreach (var item in request.SecurLogin)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<SecurityLoginsLogs> GetSecurityLoginsLogs(Empty request, ServerCallContext context)
        {
            List<SecurityLoginsLog> protos = new List<SecurityLoginsLog>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }

            SecurityLoginsLogs securLogins = new SecurityLoginsLogs();
            securLogins.SecurLogin.AddRange(protos);

            return new Task<SecurityLoginsLogs>(() => securLogins);
        }


        private SecurityLoginsLogPoco TranslateFrom(SecurityLoginsLog proto)
        {
            return new SecurityLoginsLogPoco()
            {
                Id = Guid.Parse(proto.Id),
                Login = Guid.Parse(proto.Login),
                SourceIP = proto.SourceIP,                
                LogonDate = proto.LogonDate.ToDateTime(),
                IsSuccesful = proto.IsSuccesful
            };
        }

        private SecurityLoginsLog TranslateTo(SecurityLoginsLogPoco poco)
        {
            return new SecurityLoginsLog()
            {
                Id = poco.Id.ToString(),
                Login = poco.Login.ToString(),
                SourceIP = poco.SourceIP,                
                LogonDate = poco.LogonDate == null ? null : Timestamp.FromDateTime((DateTime)poco.LogonDate),                
                IsSuccesful = poco.IsSuccesful

            };
        }
    }
}
