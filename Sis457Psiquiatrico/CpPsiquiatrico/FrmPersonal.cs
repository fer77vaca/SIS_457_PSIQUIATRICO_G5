using ClnPsiquiatrico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpPsiquiatrico
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
            dgvLista.DataSource = PersonalCln.listarPa("");
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {

        }
    }
}
