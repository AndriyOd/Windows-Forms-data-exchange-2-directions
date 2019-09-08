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
    
    public partial class Form2 : Form
    {
        // Attributes
        //public object sndr = null;
        //private Form1 f_parent;

        // !!! IT WORKS !!! --- Method 4 ---
        public event MyDelegate MyEvent;

        // !!! IT WORKS !!! --- Method 3 ---
        private MyDelegate del_f2;

        // !!! IT WORKS !!! --- Method 3 ---
        //public Form2(MyDelegate func)
        public Form2()
        {
            InitializeComponent();
            //func("Delegate works");


            // !!! IT WORKS !!! --- Method 3 ---
            //del_f2 = func;
            
            //f1.label2.Text = this.textBox1.Text;

            /*
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                this.label2.Text= main.label1.Text;
                main.label2.Text = this.textBox1.Text;
            } 
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.label2.Text = this.sndr.ToString();
            this.label2.Text = this.textBox1.Text;

            // !!! IT WORKS !!! --- Method 4 ---
            MyEvent(this.textBox1.Text);

            // !!! IT WORKS !!! --- Method 3 ---
            //del_f2(this.textBox1.Text);

            // IT WORKS !!! --- Method 1 ---
            // GlbClass1.GlbTxt01 = this.textBox1.Text;

            // !!! IT WORKS !!! --- Method 2 (!!! 2 directions !!!) ---
            /*
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                //this.label2.Text = main.label1.Text;
                this.label2.Text = main.textBox1.Text;
                main.label2.Text = this.textBox1.Text;
            }
            */

            //main.label2.Text = this.textBox1.Text;
            //f1.label2.Text = this.textBox1.Text;
            //this.sndr.

        }
    }
}
