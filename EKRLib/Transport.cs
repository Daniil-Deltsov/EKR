using System.Text.RegularExpressions;

namespace EKRLib
{
    public abstract class Transport
    {
        public Transport(string model, uint power)
        {
            this.Model = model;
            this.Power = power;
        }
        private string model;
        private uint power;
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (!Regex.IsMatch(value, @"[A-Z0-9]{5}"))
                    throw new TransportException($"Недопустимая модель {value}");
                this.model = value;
            }
        }
        public uint Power
        {
            get { return this.power; }
            set
            {
                if (value < 20)
                    throw new TransportException("мощность не может быть меньше 20 л.с.");
                this.power = value;
            }
        }
        public override string ToString()
        {
            return $"Model: {this.Model}, Power: {this.Power}";
        }
        public abstract string StartEngine();
    }
}