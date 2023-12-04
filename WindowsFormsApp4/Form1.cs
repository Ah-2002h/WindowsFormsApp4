using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_na.Text);
            int b = Convert.ToInt32(txt_nb.Text);

            txt_sun.Text = Convert.ToString(a + b);
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(txt_na.Text);
            int b = Convert.ToInt32(txt_nb.Text);

            txt_sun.Text = Convert.ToString(a - b);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (txt_na.Text.Trim() != 0 + "" && txt_nb.Text.Trim() != 0 + "")
            {
                int a = Convert.ToInt32(txt_na.Text);
                int b = Convert.ToInt32(txt_nb.Text);

                txt_sun.Text = Convert.ToString(a * b);
            }
            else
            {
                MessageBox.Show("Erro The Number ");

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txt_na.Text.Trim() != 0 + "" && txt_nb.Text.Trim() != 0 + "")
            {
                int a = Convert.ToInt32(txt_na.Text);
                int b = Convert.ToInt32(txt_nb.Text);

                txt_sun.Text = Convert.ToString(a / b);
            }
            else
            {
                MessageBox.Show("Erro The Number ");

            }
        }

        private void Txt_na_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_nb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void bt(EventArgs e, Button bb)
        {
            //bb.BackColor = Color.Brown;

        }
        public void bbt2(EventArgs e, Control bb)
        {
            bb.BackColor = Color.White;

        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            bt(e, btn1);
        }

        private void Btn2_MouseHover(object sender, EventArgs e)
        {
            bt(e, btn2);
        }

        private void Btn3_MouseHover(object sender, EventArgs e)
        {
            bt(e, btn3);
        }

        private void Btn4_MouseHover(object sender, EventArgs e)
        {
            bt(e, btn4);
        }


        private void Btn1_MouseLeave_1(object sender, EventArgs e)
        {
            bbt2(e, btn1);

        }


        private void Btn2_MouseLeave_1(object sender, EventArgs e)
        {
            bbt2(e, btn2);
        }

        private void Btn3_MouseLeave_3(object sender, EventArgs e)
        {

        }
        private void Btn4_MouseLeave_4(object sender, EventArgs e)
        {

        }

        private void Btn1_Leave(object sender, EventArgs e)
        {

        }

        private void Btn3_Leave(object sender, EventArgs e)
        {

        }

        private void Btn4_Leave(object sender, EventArgs e)
        {
            bbt2(e, btn4);

        }

        private void Btn1_MouseLeave(object sender, EventArgs e)
        {
            bbt2(e, btn1);

        }

        private void Btn3_MouseLeave(object sender, EventArgs e)
        {
            bbt2(e, btn3);

        }

        private void Btn4_MouseLeave(object sender, EventArgs e)
        {
            bbt2(e, btn4);

        }

        private void Btn2_Leave(object sender, EventArgs e)
        {
        }

        private void Btn2_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Brown;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
           
         
        }
    }
}
