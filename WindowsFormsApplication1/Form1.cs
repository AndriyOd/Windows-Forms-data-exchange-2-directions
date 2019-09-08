using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Attributes
        public string Txt = "Initial text +";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //MessageBox.Show("You have clicked the button");
           this.button2.Text = this.textBox1.Text;
            this.label1.Text = this.textBox1.Text;

            // !!! IT WORKS !!! --- Method 3 ---
            //Form2 fm2 = new Form2(new MyDelegate(MyFunction));
            Form2 fm2 = new Form2();

            // !!! IT WORKS !!! --- Method 4 ---
            fm2.MyEvent += MyFunction;

            // !!! IT WORKS !!! --- Method 2 ---
            //fm2.Owner = this;



            // fm2.label1.Text = this.textBox1.Text;
            //this.label2.Text = fm2.textBox1.Text;

            //fm2.sndr = sender;
            //fm2.label2.Text = (string)sender;
            //this.label2.Text = fm2.textBox1.Text;


           fm2.ShowDialog();
           //fm2.Show(); // ALSO WORKS!!!
        }

        // !!! IT WORKS !!! --- Methods 3,4 ---
        void MyFunction(string TextData)
        {
            this.label2.Text = TextData;
        }

        private void Func2(object sender, EventArgs e)
        {
            MessageBox.Show("Func2 MsgBox");
            this.label2.Text = GlbClass1.GlbTxt01;
        }


    }
}
