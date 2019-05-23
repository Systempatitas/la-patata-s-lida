using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SysAlquiler
{
    public partial class Reg_Tarifacs : Form
    {

        public Reg_Tarifacs()
        {
            InitializeComponent();
        }

        private void Reg_Tarifacs_Load(object sender, EventArgs e)
        {
           
        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_tarifa_Click(object sender, EventArgs e)
        {
            Buscar_Tarifa bt = new Buscar_Tarifa();
            bt.ShowDialog();
        }

        private void btn_buscarconcp_Click(object sender, EventArgs e)
        {
            Buscar_concepto_form_Tarif bc = new Buscar_concepto_form_Tarif();
            bc.ShowDialog();
        }
    }
}
    

