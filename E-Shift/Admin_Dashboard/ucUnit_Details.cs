using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift.Admin_Dashboard
{
    public partial class ucUnit_Details : UserControl
    {
        DBase_Cls DB = new DBase_Cls();

        public ucUnit_Details()
        {
            InitializeComponent();
        }

        private void ucUnit_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
