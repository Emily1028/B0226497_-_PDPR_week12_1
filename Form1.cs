using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace B0226497_段昱如_PDPR_week12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        String str = "";
        Random rnd = new Random();
        private void btnOK_Click(object sender, EventArgs e)
        {
            List<BOOKS> listgBOOKS = new List<BOOKS>();
            for (int i = 0; i < 10; i++)
            {
                BOOKS book = new BOOKS($"B0226497{i}", $"安徒生童話_{i + 1}", $"安徒生", rnd.Next(100, 500));
                str += book.printME();
            }
            lblRESULT.Text = str;
        }


    }
}
