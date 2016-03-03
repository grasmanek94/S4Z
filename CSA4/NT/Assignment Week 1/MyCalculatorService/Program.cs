using System;
using System.ServiceModel;
using MyCalculatorContract;

namespace MyCalculatorService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Calculator));

            Type contract = typeof(ICalculator);
            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorservice");
            host.AddServiceEndpoint(contract, binding, address);

            host.Open();

            Console.WriteLine("The service is being hosted at address " + address);
            Console.WriteLine("Press <ENTER> to stop hosting.\n");
            Console.ReadLine();

            host.Close();
        }
    }
}
