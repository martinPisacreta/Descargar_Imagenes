using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargar_Imagenes
{
    public partial class frm_Eliminar_Imagen_por_Path : Form
    {
        public string ruta_url_imagenes { get; set; }
        public frm_Eliminar_Imagen_por_Path(string _ruta_url_imagenes)
        {
            InitializeComponent();

            DataTable data_table_datos = new DataTable();
            ruta_url_imagenes = _ruta_url_imagenes;
            
            using (Stream inputStream = File.OpenRead(ruta_url_imagenes))
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

                    File.Delete(dtRow["path"].ToString());

                }
                catch (Exception ex)
                {
                    this.dataGridView1.Rows.Add(dtRow["path"].ToString());
                }
            }


          
        }
    }
}

