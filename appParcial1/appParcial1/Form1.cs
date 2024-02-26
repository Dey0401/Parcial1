using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libOpeParcial1;
     
namespace appParcial1
{
    public partial class frmParcial1 : Form
    {
        public frmParcial1()
        {
            InitializeComponent();
        }

        #region Metodos propios
        private void Mensaje(string texto)
        {
            MessageBox.Show(texto);
        }
        private void llenarCombo()
        {
            this.cmbDato.Items.Add("Seleccione un producto"); //Index = 0
            this.cmbDato.Items.Add("Producto 1"); //Index = 1 (cod : 110)
            this.cmbDato.Items.Add("Producto 2"); //Index = 2 (cod : 215)
            this.cmbDato.Items.Add("Otros productos"); //Index = 3
            this.cmbDato.SelectedIndex = 0;
        }
        private void Limpiar()
        {
            this.cmbDato.SelectedIndex = 0;
            //this.txtVrDocena.Text = string.Empty;
            //this.txtCant.Text = string.Empty;
            //this.txtIVA.Text = string.Empty;
            //this.grbAPagar.Visible = false;
            this.cmbDato.Focus();
        }
        #endregion

        #region Metodos de los botones
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Mensaje("Se limpiaron los campos correctamente");
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            int intcod, intcant;
            float fltvrd, fltpiva;
            try
            {
                //Capturamos el dato
                intcod = this.cmbDato.SelectedIndex;

                switch (intcod)
                {
                    case 0:
                        Mensaje("prosucto no valido");
                        this.cmbDato.Focus();
                        return;
                    case 1:
                        intcod = 110;
                        break;
                    case 2:
                        intcod = 215;
                        break;
                    default:
                        intcod = 999;
                        break;
                }
                //fltvrd = Convert.ToSingle(this.txtVrDocena.Text);
                //intcant = Convert.ToInt32(txtCant.Text);
                //fltpiva = Convert.ToSingle(this.txtIVA.Text);
                //crear objeto OPE
                clsOpeParcial1 obj = new clsOpeParcial1();
                //Enviar info al objeto
                //oO.Codigo = intcod;
                //oO.vrDocena = fltvrd;
                //oO.Cantidad = intcant;
                //oO.porcIVA = fltpiva;

                //Invocar metodo y Tto del error
                if (!obj.Facturar())
                {
                    Mensaje(obj.Error);
                    obj = null; //Garbage Collector
                    return;
                }
                //Recuperación de la info
                //this.lblxxx.Text = Convert.ToString(oO.subTotal);
                //this.lblPorcDscto.Text = oO.porcDscto.ToString();
                //this.lblVrDscto.Text = oO.vrDscto.ToString();
                //this.lblVrIVA.Text = oO.vrIva.ToString();
                //this.lblTotAPag.Text = oO.totalAPagar.ToString();
                //Mostrar group box
                this.grMostar.Visible = true;
                obj = null; //Garbage Collector
            }

            catch (Exception ex)
            {
                Mensaje(ex.Message);
                throw;
            }


        }
        #endregion
        private void frmParcial1_Load(object sender, EventArgs e)
        {
            llenarCombo();
        }


    }
}
