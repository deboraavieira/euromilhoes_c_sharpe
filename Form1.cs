using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3939_DeboraVieira_T02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            int[] label1 = new int[5];
            int[] label2= new int[2];
            Random rnd = new Random();


            for (int i = 0; i < label1.Length; i++)
            {
                int num_aleatorio1;
                do
                {
                    num_aleatorio1= rnd.Next(1,51);
                }while(num_aleatorio1<label1.Length);
                    label1[i] = num_aleatorio1;
            }
            for (int i = 0; i < label2.Length; i++)
            {
                int num_aleatorio2;
                do
                {
                    num_aleatorio2 = rnd.Next(1, 13);
                } while (num_aleatorio2 < label2.Length);
                label2[i] = num_aleatorio2;
            }

                    lbl_num1L1.Text = label1[0].ToString();
                    lbl_num2L1.Text = label1[1].ToString();
                    lbl_num3L1.Text = label1[2].ToString();
                    lbl_num4L1.Text = label1[3].ToString();
                    lbl_num5L1.Text = label1[4].ToString();
                    lbl_num1L2.Text = label2[0].ToString();
                    lbl_num2L2.Text = label2[1].ToString();
            


        }
    }
}
