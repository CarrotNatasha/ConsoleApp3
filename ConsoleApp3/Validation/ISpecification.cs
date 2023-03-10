using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Validation
{
    public interface ISpecification<T>
    {
        void Validate(T value);
    }
    /* public class ISpecNotInterface<T> : ISpecification<T>
    {
        public void Validate(T tValue)
        {
            int iValue = 0;
            if (Int32.TryParse(tValue, out iValue)
            {

            }
        }
    } */

    public class AndSpecification<T> : ISpecification<T>
    {
        ISpecification<T> spec1 = null, spec2 = null;
        public AndSpecification(ISpecification<T> s1,ISpecification<T> s2)
        {
            spec1 = s1;
            spec2 = s2;
        }
        public void Validate(T tValue)
        {
            spec1.Validate(tValue);
            spec2.Validate(tValue);
        }
    }
}
