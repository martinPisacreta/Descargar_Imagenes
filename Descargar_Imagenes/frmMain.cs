using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargar_Imagenes
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            try
            {
                string hoja = "";
                //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Archivos de Excel (*.xls;*.xlsx;*.xlsm)|*.xls;*.xlsx;*.xlsm"; //le indicamos el tipo de filtro en este caso que busque solo los archivos excel

                dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

                dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

                //si al seleccionar el archivo damos Ok
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                 
                    //el nombre del archivo sera asignado al textbox
                    txtArchivoExcel.Text = dialog.FileName;
                    hoja = "Articulo"; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
                    Cursor.Current = Cursors.Default;
                }

            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnfrm_Descargar_Imagenes_por_URL_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArchivoExcel.Text == "")
                {
                    throw new Exception("Debe seleccionar un archivo excel");
                }
                else
                {
                    frm_Descargar_Imagenes_por_URL form = new frm_Descargar_Imagenes_por_URL(txtArchivoExcel.Text);
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfrm_Eliminar_Imagen_por_Path_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArchivoExcel.Text == "")
                {
                    throw new Exception("Debe seleccionar un archivo excel");
                }
                else
                {
                    frm_Eliminar_Imagen_por_Path form = new frm_Eliminar_Imagen_por_Path(txtArchivoExcel.Text);
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfrm_Existe_Imagen_en_carpeta_Imagenes_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArchivoExcel.Text == "")
                {
                    throw new Exception("Debe seleccionar un archivo excel");
                }
                else
                {
                    frm_Existe_Imagen_en_carpeta_Imagenes form = new frm_Existe_Imagen_en_carpeta_Imagenes(txtArchivoExcel.Text);
                    form.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfrmMover_Imagen_De_Carpeta_y_Renombrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArchivoExcel.Text == "")
                {
                    throw new Exception("Debe seleccionar un archivo excel");
                }
                else
                {
                    frmMover_Imagen_De_Carpeta_y_Renombrar form = new frmMover_Imagen_De_Carpeta_y_Renombrar(txtArchivoExcel.Text);
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
