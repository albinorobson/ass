using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.Formularios.Cadastros;

namespace WindowsFormsApplication3.Formularios
{
    public partial class frm_cad_cliente : Form
    {
        public frm_cad_cliente()
        {
            InitializeComponent();
        }

        private void rb_cnpj_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "00.000.000/0000-00";
        }

        private void rb_cpf_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "000.000.000-00";
        }

       private void frm_cad_cliente_Load(object sender, EventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e)
       {
           frm_cad_endereco oform = new frm_cad_endereco();
           oform.ShowDialog();
       }
    }
}
