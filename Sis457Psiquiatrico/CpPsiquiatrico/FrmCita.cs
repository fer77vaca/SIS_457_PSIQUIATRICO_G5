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
    public partial class FrmCita : Form
    {
        public FrmCita()
        {
            InitializeComponent();
            dgvLista.DataSource = CitaCln.listarPa("");
        }
    }
}
