using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.ApplicantJobApplicationService;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantJobApplicationController : ApplicantJobApplicationServiceBase
    {
        private readonly ApplicantJobApplicationLogic _logic;

        public ApplicantJobApplicationController()
        {
            _logic = new ApplicantJobApplicationLogic(new EfGenericRepository<ApplicantJobApplicationPoco>());
        }
        public override Task<ApplicantJobApplication> GetApplicantJobApplication(IdRequest2 request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);            
            return new Task<ApplicantJobApplication>(() => TranslateTo(_logic.Get(id)));
        }

        public override Task<Empty> AddApplicantJobApplication(ApplicantJobApplications request, ServerCallContext context)
        {
            List<ApplicantJobApplicationPoco> pocos = new List<ApplicantJobApplicationPoco>();
            foreach (var item in request.AppJobAppl)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateApplicantJobApplication(ApplicantJobApplications request, ServerCallContext context)
        {
            List<ApplicantJobApplicationPoco> pocos = new List<ApplicantJobApplicationPoco>();
            foreach (var item in request.AppJobAppl)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteApplicantJobApplication(ApplicantJobApplications request, ServerCallContext context)
        {
            List<ApplicantJobApplicationPoco> pocos = new List<ApplicantJobApplicationPoco>();
            foreach (var item in request.AppJobAppl)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<ApplicantJobApplications> GetApplicantJobApplications(Empty request, ServerCallContext context)
        {
            List<ApplicantJobApplication> protos = new List<ApplicantJobApplication>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }

            ApplicantJobApplications AppJobAppls = new ApplicantJobApplications();
            AppJobAppls.AppJobAppl.AddRange(protos);

            return new Task<ApplicantJobApplications>(() => AppJobAppls);
        }


        private ApplicantJobApplicationPoco TranslateFrom(ApplicantJobApplication proto)
        {
            return new ApplicantJobApplicationPoco()
            {
                Id = Guid.Parse(proto.Id),
                Applicant = Guid.Parse(proto.Applicant),
                Job = Guid.Parse(proto.Job),               
                ApplicationDate = proto.ApplicationDate.ToDateTime()
               
            };
        }

        private ApplicantJobApplication TranslateTo(ApplicantJobApplicationPoco poco)
        {
            return new ApplicantJobApplication()
            {
                Id = poco.Id.ToString(),
                Applicant = poco.Applicant.ToString(),
                Job = poco.Job.ToString(),

                ApplicationDate = poco.ApplicationDate == null ? null : Timestamp.FromDateTime((DateTime)poco.ApplicationDate),
                

            };
        }


    }
}
