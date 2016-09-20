using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using claseTres; //Necesario referenciar

namespace claseTresFormUI
{
    public partial class Form1 : Form
    {

        private Carrera miCarrera;


        public Form1()
        {
            InitializeComponent();

            // Datos de testeo
            this.txtNombre.Text = "daytona";
            this.txtFecha.Text = "26/10/16";
            this.txtLugar.Text = "USA";


            this.cmbCorrerCarrera.Items.Add("Por Tiempo");
            this.cmbCorrerCarrera.Items.Add("Por Kilometro");
            this.cmbCorrerCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCorrerCarrera.SelectedIndex = 0;

            this.cmbOrdenar.Items.Add("Fabricante");
            this.cmbOrdenar.Items.Add("Piloto");

            //Permite que mi cmbBox no sea editable
            this.cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOrdenar.SelectedIndex = 0;

            this.rbAscendente.Checked = true;

            //Manera de cargar cmbBox a partir de un enumerado
            foreach (eFabricante item in Enum.GetValues(typeof(eFabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }

            this.cmbFabricante.SelectedIndex = 1;
            this.cmbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

        private void btnCrearCarrera_Click(object sender, EventArgs e)
        {
            miCarrera = new Carrera(this.txtNombre.Text, this.txtLugar.Text, this.txtFecha.Text);
            gpbCarrera.Enabled = false;
            gpbAutos.Enabled = true;

            // Datos de testeo
            Auto miAuto = new Auto("Diego", (eFabricante)1);
            this.miCarrera = this.miCarrera + miAuto;
            miAuto = new Auto("Marcela", (eFabricante)2);
            this.miCarrera = this.miCarrera + miAuto;
            miAuto = new Auto("Uriel", (eFabricante)0);
            this.miCarrera = this.miCarrera + miAuto;
            listarAutos();
            
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            Auto miAuto = new Auto(this.txtNombrePiloto.Text, (eFabricante)cmbFabricante.SelectedItem);
            this.miCarrera = this.miCarrera + miAuto;
            listarAutos();
        }


        private void btnCorrerCarrera_Click(object sender, EventArgs e)
        {
            if (cmbCorrerCarrera.SelectedIndex == 0)
            {
                this.miCarrera.CorrerCarrera((Tiempo)100);
            }
            else if (cmbCorrerCarrera.SelectedIndex == 1)
            {
                this.miCarrera.CorrerCarrera((Kilometro)100);
            }

            txtResultado.Text = this.miCarrera.MostrarCarrera();
        }


        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            switch (this.cmbOrdenar.SelectedIndex)
            {
                case 0:
                    if (rbAscendente.Checked == true)
                    {
                        this.miCarrera.listaDeAutos.Sort(Auto.ordenarPorFabricanteAsc);
                    }
                    else if (rbDescendente.Checked == true)
                    {
                        this.miCarrera.listaDeAutos.Sort(Auto.ordenarPorFabricanteDesc);
                    }
                    break;
                case 1:
                    if (rbAscendente.Checked == true)
                    {
                        this.miCarrera.listaDeAutos.Sort(Auto.ordenarPorPilotoAsc);
                    }
                    else if (rbDescendente.Checked == true)
                    {
                        this.miCarrera.listaDeAutos.Sort(Auto.ordenarPorPilotoDesc);
                    }
                    break;
            }

            listarAutos();
        }



        #region Metodos

        public void listarAutos()
        {
            lsbListaAutos.Items.Clear();
            foreach (Auto item in this.miCarrera.listaDeAutos)
            {
                this.lsbListaAutos.Items.Add(item.DatosEnString);
            }
        }

        #endregion Metodos
        



    }
}
