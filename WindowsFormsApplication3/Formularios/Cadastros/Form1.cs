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
using WindowsFormsApplication3.Formularios;

namespace WindowsFormsApplication3
{

    public partial class Form1 : Form
    {
        DataTable tabela = new DataTable();
        int contadori, contadorl = 0;
        List<Teste> t = new List<Teste>();

        public Form1()
        {
            InitializeComponent();
            this.teste();


        }

        public void teste()
        {
           
                t.Add(new Teste(1,"robson"));
                t.Add(new Teste(2, "Pedro"));
            
          

            cb_itemservico.DataSource = t;
            cb_itemservico.DisplayMember= "Descricao";
            cb_itemservico.ValueMember = "ID";
            
        }


        private void btn_adicionarservico_Click(object sender, EventArgs e)
        {            
            contadorl++;
        
            for (contadori = contadori; contadori < contadorl; contadori++)
            {

                foreach (Teste te in t)
                {

                    if ((int) cb_itemservico.SelectedValue == te.ID)
                    {
                        MessageBox.Show(te.Descricao);
                    }
                }

               

                dg_servico.Rows.Add(new Object[]{cb_itemservico.SelectedValue});
          
            }

        }

            private void dg_servico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("" + dg_servico.SelectedRows[0].Cells[0].Value);
        }

            private void Form1_Load(object sender, EventArgs e)
            {

                // Create the list to use as the custom source. 
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                source.AddRange(new string[]
                    {
                        "January",
                        "February",
                        "March",
                        "April",
                        "May",
                        "June",
                        "July",
                        "August",
                        "September",
                        "October",
                        "November",
                        "December"
                    });
                txt_cliente.AutoCompleteCustomSource = source;
                txt_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                frm_cad_cliente oform = new frm_cad_cliente();
                oform.Show();
                
            }
     
    }
}
