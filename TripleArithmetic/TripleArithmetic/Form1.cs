using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleArithmetic
{
    public partial class Form1 : Form
    {
        readonly ServiceReference1.Service1Client _objClient = new ServiceReference1.Service1Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objOne = _objClient.NewTriple(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox5.Text),
                Convert.ToInt32(textBox4.Text));
            var objTwo = _objClient.NewTriple(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox2.Text),
                Convert.ToInt32(textBox1.Text));

            var obj = _objClient.MethodThreeIntClass(objOne, objTwo);

            richTextBox1.AppendText("Object calculation done, object 1 + 2 = \n" + obj.NumberOne + "\n" + obj.NumberTwo + "\n" + obj.NumberThree);
        }
    }
}