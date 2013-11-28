using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using close;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private bool isOpen = false;

        public Form1()
        {
            InitializeComponent();
            setDataField();
        }
        
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                CloseMedia.Open();
                isOpen = true;
                btnAbrir.Text = "Close";
            }
            else
            {
                CloseMedia.Close();
                isOpen = false;
                btnAbrir.Text = "Open";
            }
            
        }

        private void setDataField()
        {
            btnAbrir.Text = "Open";
        }
    }
}
