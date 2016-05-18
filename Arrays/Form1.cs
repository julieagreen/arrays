using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, EventArgs e)
        {
            try
            {

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
