using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using MyCalculatorContract;

namespace MyCalculatorClient
{
    public interface ICalculatorChannel : ICalculator, IClientChannel
    {
    }


    public class CalculatorClient : ClientBase<ICalculator>, ICalculator
    {
        public CalculatorClient()
        {
        }

        public CalculatorClient(string endPointConfigurationName)
            : base(endPointConfigurationName)
        {
        }

        public CalculatorClient(string endPointConfigurationName, string remoteAddress)
            : base(endPointConfigurationName, remoteAddress)
        {
        }

        public CalculatorClient(string endPointConfigurationName, EndpointAddress remoteAddress)
            : base(endPointConfigurationName, remoteAddress)
        {
        }

        public CalculatorClient(Binding endPointConfigurationName, EndpointAddress remoteAddress)
            : base(endPointConfigurationName, remoteAddress)
        {
        }
        public double Add(double a, double b)
        {
            return base.Channel.Add(a, b);
        }

        public double Substract(double a, double b)
        {
            return base.Channel.Substract(a, b);
        }

        public double Multiply(double a, double b)
        {
            return base.Channel.Multiply(a, b);
        }

        public double Divide(double a, double b)
        {
            return base.Channel.Divide(a, b);
        }
    }
}
