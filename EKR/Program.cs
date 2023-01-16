using EKRLib;
using System.Text;

namespace EKR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rnd = new Random();
            List<Transport> transports = new List<Transport>();
            for (int i = 0; i < rnd.Next(6, 9); i++)
            {
                string model = new String(Enumerable.Range(1, 5).Select(c => chars[rnd.Next(chars.Length)]).ToArray());
                uint power = (uint)rnd.Next(10, 99);
                try
                {
                    switch (rnd.Next(0, 2))
                    {
                        case 0:
                            transports.Add(new Car(model, power));
                            break;
                        case 1:
                            transports.Add(new MotorBoat(model, power));
                            break;
                    }
                }
                catch (TransportException ex)
                {
                    i--;
                    Console.WriteLine(ex.Message);
                }
            }
            StringBuilder cars = new StringBuilder();
            StringBuilder boats = new StringBuilder();

            foreach (Transport item in transports)
            {
                if (item is Car)
                    cars.AppendLine(item.ToString());
                else
                    boats.AppendLine(item.ToString());
            }
            File.WriteAllText("Cars.txt", cars.ToString(), Encoding.GetEncoding("utf-16"));
            File.WriteAllText("MotorBoats.txt", boats.ToString(), Encoding.GetEncoding("utf-16"));
        }
    }
}