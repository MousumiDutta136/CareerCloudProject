using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.ApplicantEducationService;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantEducationController : ApplicantEducationServiceBase
    {
        private readonly ApplicantEducationLogic _logic;

        public ApplicantEducationController()
        {
            _logic = new ApplicantEducationLogic(new EfGenericRepository<ApplicantEducationPoco>());
        }
        public override Task<ApplicantEducation> GetApplicantEducation(IdRequest1 request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);           
            return new Task<ApplicantEducation>(() => TranslateTo(_logic.Get(id)));
        }

        private ApplicantEducation TranslateTo(ApplicantEducationPoco poco)
        {
            return new ApplicantEducation()
            {
                Id = poco.Id.ToString(),
                Applicant = poco.Applicant.ToString(),
                Major = poco.Major,
                CertificateDiploma = poco.CertificateDiploma,
                StartDate = poco.StartDate == null ? null : Timestamp.FromDateTime((DateTime)poco.StartDate),
                CompletionDate = poco.CompletionDate == null ? null : Timestamp.FromDateTime((DateTime)poco.CompletionDate),
                CompletionPercent = poco.CompletionPercent

            };
        }

        public override Task<Empty> AddApplicantEducation(ApplicantEducations request, ServerCallContext context)
        {
            List<ApplicantEducationPoco> pocos = new List<ApplicantEducationPoco>();
            foreach (var item in request.AppEdu)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateApplicantEducation(ApplicantEducations request, ServerCallContext context)
        {
            List<ApplicantEducationPoco> pocos = new List<ApplicantEducationPoco>();
            foreach (var item in request.AppEdu)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteApplicantEducation(ApplicantEducations request, ServerCallContext context)
        {
            List<ApplicantEducationPoco> pocos = new List<ApplicantEducationPoco>();
            foreach (var item in request.AppEdu)
            {
                pocos.Add(TranslateFrom(item));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<ApplicantEducations> GetApplicantEducations(Empty request, ServerCallContext context)
        {
            List<ApplicantEducation> protos = new List<ApplicantEducation>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }

            ApplicantEducations appEdus = new ApplicantEducations();
            appEdus.AppEdu.AddRange(protos);

            return new Task<ApplicantEducations>(() => appEdus);
        }


        private ApplicantEducationPoco TranslateFrom(ApplicantEducation proto)
        {
            return new ApplicantEducationPoco()
            {
                Id = Guid.Parse(proto.Id),
                Applicant = Guid.Parse(proto.Applicant),
                Major = proto.Major,
                CertificateDiploma = proto.CertificateDiploma,
                StartDate = proto.StartDate.ToDateTime(),
                CompletionDate = proto.CompletionDate.ToDateTime(),
                CompletionPercent = (byte?)proto.CompletionPercent
            };
        }




    }
}
