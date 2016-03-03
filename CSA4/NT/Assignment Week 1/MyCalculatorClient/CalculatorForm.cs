using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace MyCalculatorClient
{
    public partial class CalculatorForm : Form
    {
        private CalculatorClient proxy;

        public CalculatorForm()
        {
            InitializeComponent();

            // instantiate a proxy to contact the service
            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorservice");
            EndpointAddress endpointAddress = new EndpointAddress(address);
            proxy = new CalculatorClient(binding, endpointAddress);
        }

        private void performOp(Func<double, double, double> func)
        {
            try
            {
                tb_result.Text = 
                    func(
                        Convert.ToDouble(tb_a.Text), 
                        Convert.ToDouble(tb_b.Text)
                    ).ToString();
            }
            catch(Exception e)
            {
                tb_result.Text = "Error: " + e.Message;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            performOp(proxy.Add);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            performOp(proxy.Substract);
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            performOp(proxy.Multiply);
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            performOp(proxy.Divide);
        }
    }
}
