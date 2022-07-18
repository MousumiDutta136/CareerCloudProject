using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SecurityLoginsLogLogic : BaseLogic<SecurityLoginsLogPoco>
    {
        public SecurityLoginsLogLogic(IDataRepository<SecurityLoginsLogPoco> repo) : base(repo)
        {

        }
        public override void Add(SecurityLoginsLogPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);

        }
        public override void Update(SecurityLoginsLogPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        protected override void Verify(SecurityLoginsLogPoco[] pocos)
        {
            List<ValidationException> errors = new List<ValidationException>();
            foreach (SecurityLoginsLogPoco poco in pocos)
            {


                if (errors.Count > 0)
                {
                    throw new AggregateException(errors);
                }

            }
        }
    }
}
