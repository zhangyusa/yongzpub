using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YongTest.CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order order = new Order() { CustomerName = "Test", OrderId = 98120 };
            order.AddDetail("Item 1", 1, 120)
                 .AddDetail("Item 2", 2, 220)
                 .AddDetail("Item 3", 1, 110);
            textBox1.Text = $"{order.GetOrderTotalAmount().ToString("c")}\r\n";
            foreach (var detail in order.FindItem("Item 1"))
                textBox1.Text += $"{detail.Item}: {detail.Quantity * detail.Price}\r\n";
            foreach (var detail in order.Details)
                textBox1.Text += $"{detail.Item}: {detail.Quantity * detail.Price}\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // new constructor
            Order order = new Order() { CustomerName = "Test", OrderId = 98120 };
            textBox1.Text = $"{order.ToString()}\r\n";
            // new initializer
            Dictionary<int, string> dict = new Dictionary<int, string>() {[1] = "John",[2] = "Test",[5] = "Number 5" };
            Func<string> f = ()=> { string s=""; foreach (var v in dict) s += $"{v.Key} = {dict[v.Key]}\r\n"; return s; };
            textBox1.Text += f.Invoke();
            order.ChangeCustomerName("Changed Name");
            textBox1.Text += $"{order.ToString()}\r\n";
            order = null;
            textBox1.Text += order?.CustomerName ?? "Null order or customer name"; 
        }

        protected async void mActionHandler(string action)
        {
            textBox1.Text = action + " start...";
            switch (action)
            {
                case "GetContractNo":
                    EntityFrameTest test = new EntityFrameTest();
                    textBox1.Text = test.GetContractNo(DateTime.Parse("9/2/2014"));
                    break;
                case "GetContractNoAsync":
                    EntityFrameTest test2 = new EntityFrameTest();
                    textBox1.Text = await test2.GetContractNoAsync(DateTime.Parse("9/2/2014"));
                    break;
                case "GetContractNoAndBalance":
                    EntityFrameTest test3 = new EntityFrameTest();
                    textBox1.Text = test3.GetContractNoAndBalance(DateTime.Parse("9/2/2014"));
                    break;
                default:
                    // prefix with $, the {} is interpreted
                    // nameof function
                    textBox1.Text = $"{nameof(mActionHandler)} reports Unknown action: {action}";
                    break;
            }
        }

        private void mMenuItemClickHandler(object sender, EventArgs e) => 
            this.mActionHandler((string)((ToolStripMenuItem)sender).Tag); 
        
    }
}
