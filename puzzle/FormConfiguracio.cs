using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    public partial class FormConfiguracio : Form
    {
        private Configuracio configuracio;
        private Form1 form1;

        public FormConfiguracio(Configuracio configuracio, Form1 form1)
        {
            InitializeComponent();
            this.configuracio = configuracio;
            numericUpDownMov.Value = configuracio.getNumMovimentsMaxim();
            this.form1 = form1;
        }

        private void avisarFormPropietario(object sender, FormClosingEventArgs e)
        {
            configuracio.setNumMovimentsMaxim((int)numericUpDownMov.Value);
            form1.configuracionCambiada();
        }
    }
}
