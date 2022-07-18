using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobLogic : BaseLogic<CompanyJobPoco>
    {
        public CompanyJobLogic(IDataRepository<CompanyJobPoco> repo) : base(repo)
        {

        }
        public override void Add(CompanyJobPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);

        }
        public override void Update(CompanyJobPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        protected override void Verify(CompanyJobPoco[] pocos)
        {
            List<ValidationException> errors = new List<ValidationException>();
            foreach (CompanyJobPoco poco in pocos)
            {
                

                if (errors.Count > 0)
                {
                    throw new AggregateException(errors);
                }

            }
        }
    }
}
