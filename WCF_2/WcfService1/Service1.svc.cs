using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public struct opt
    {
        public double Fopt;
        public double[] Xopt;

    }

    public class Service1 : IService1
    {

        public opt MonteCarloOptim(int n, int iter)
        {
            Random rand = new Random();
            double f1 = 0.0;
            double f2 = 0.0;
            int A = 10;
            double Value = 0.0;
            double minValue = double.MaxValue;

            double[] x = new double[n];
            double[] Xopt = new double[n];
            opt optim = new opt();
            optim.Xopt = new double[n];
            for (int j = 0; j < iter; j++)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = -5.12 + rand.NextDouble() * (5.12 + 5.12);
                    f2 += Math.Pow(x[i], 2) - A * Math.Cos(2 * Math.PI + x[i]);
                }

                f1 = A * n + f2;
                Value = f1;

                if (Value < minValue)
                {
                    minValue = Value;
                    for (int i = 0; i < Xopt.Length; i++)
                    {
                        optim.Xopt[i] = x[i];
                    }
                }
                optim.Fopt = minValue;
                f2 = 0.0;
            }


            return optim;
        }

        public double Sin(double value)
        {
            return Math.Sin(value);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
