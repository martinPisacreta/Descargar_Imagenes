using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargar_Imagenes
{
    public partial class frmMover_Imagen_De_Carpeta_y_Renombrar : Form
    {

        string ruta_imagenes_mover_y_renombrar { get; set; }
        public frmMover_Imagen_De_Carpeta_y_Renombrar(string _ruta_imagenes_mover_y_renombrar)
        {
            InitializeComponent();
            DataTable data_table_datos = new DataTable();

            ruta_imagenes_mover_y_renombrar = _ruta_imagenes_mover_y_renombrar;
            using (Stream inputStream = File.OpenRead(ruta_imagenes_mover_y_renombrar))
            {
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    IApplication application = excelEngine.Excel;
                    IWorkbook workbook = application.Workbooks.Open(inputStream);
                    IWorksheet worksheet = workbook.Worksheets[0];

                    data_table_datos = worksheet.ExportDataTable(worksheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);
                }
            }

            foreach (DataRow dtRow in data_table_datos.Rows)
            {
                try
                {
                    File.Copy(dtRow["path_viejo"].ToString(), dtRow["path_nuevo"].ToString());
                }
                catch (Exception ex)
                {
                    this.dataGridView1.Rows.Add(dtRow["path_viejo"].ToString());

                }


            }
        }
    }
}
