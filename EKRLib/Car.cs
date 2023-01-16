using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    public class Car : Transport
    {
        public Car(string model, uint power) : base(model, power)
        {
        }

        public override string StartEngine()
        {
            return $"{Model}: Vroom";
        }

        public override string ToString()
        {
            return $"Car. {base.ToString()}";
        }
    }
}
