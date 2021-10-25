namespace Descargar_Imagenes
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnfrm_Descargar_Imagenes_por_URL = new System.Windows.Forms.Button();
            this.btnfrm_Eliminar_Imagen_por_Path = new System.Windows.Forms.Button();
            this.btnfrm_Existe_Imagen_en_carpeta_Imagenes = new System.Windows.Forms.Button();
            this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtArchivoExcel = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnfrm_Descargar_Imagenes_por_URL
            // 
            this.btnfrm_Descargar_Imagenes_por_URL.Location = new System.Drawing.Point(108, 58);
            this.btnfrm_Descargar_Imagenes_por_URL.Name = "btnfrm_Descargar_Imagenes_por_URL";
            this.btnfrm_Descargar_Imagenes_por_URL.Size = new System.Drawing.Size(303, 23);
            this.btnfrm_Descargar_Imagenes_por_URL.TabIndex = 0;
            this.btnfrm_Descargar_Imagenes_por_URL.Text = "Descargar Imagen por URL";
            this.toolTip1.SetToolTip(this.btnfrm_Descargar_Imagenes_por_URL, "Campos obligatorios excel: busqueda / id_articulo");
            this.btnfrm_Descargar_Imagenes_por_URL.UseVisualStyleBackColor = true;
            this.btnfrm_Descargar_Imagenes_por_URL.Click += new System.EventHandler(this.btnfrm_Descargar_Imagenes_por_URL_Click);
            // 
            // btnfrm_Eliminar_Imagen_por_Path
            // 
            this.btnfrm_Eliminar_Imagen_por_Path.Location = new System.Drawing.Point(108, 87);
            this.btnfrm_Eliminar_Imagen_por_Path.Name = "btnfrm_Eliminar_Imagen_por_Path";
            this.btnfrm_Eliminar_Imagen_por_Path.Size = new System.Drawing.Size(303, 23);
            this.btnfrm_Eliminar_Imagen_por_Path.TabIndex = 1;
            this.btnfrm_Eliminar_Imagen_por_Path.Text = "Eliminar Imagen por Path";
            this.toolTip1.SetToolTip(this.btnfrm_Eliminar_Imagen_por_Path, "Campos obligatorios excel : path");
            this.btnfrm_Eliminar_Imagen_por_Path.UseVisualStyleBackColor = true;
            this.btnfrm_Eliminar_Imagen_por_Path.Click += new System.EventHandler(this.btnfrm_Eliminar_Imagen_por_Path_Click);
            // 
            // btnfrm_Existe_Imagen_en_carpeta_Imagenes
            // 
            this.btnfrm_Existe_Imagen_en_carpeta_Imagenes.Location = new System.Drawing.Point(108, 116);
            this.btnfrm_Existe_Imagen_en_carpeta_Imagenes.Name = "btnfrm_Existe_Imagen_en_carpeta_Imagenes";
            this.btnfrm_Existe_Imagen_en_carpeta_Imagenes.Size = new System.Drawing.Size(303, 23);
            this.btnfrm_Existe_Imagen_en_carpeta_Imagenes.TabIndex = 2;
            this.btnfrm_Existe_Imagen_en_carpeta_Imagenes.Text = "Existe Imagen en carpeta Imagenes";
            this.toolTip1.SetToolTip(this.btnfrm_Existe_Imagen_en_carpeta_Imagenes, "Campos obligatorios excel: imagen_real / id_articulo");
            this.btnfrm_Existe_Imagen_en_carpeta_Imagenes.UseVisualStyleBackColor = true;
            this.btnfrm_Existe_Imagen_en_carpeta_Imagenes.Click += new System.EventHandler(this.btnfrm_Existe_Imagen_en_carpeta_Imagenes_Click);
            // 
            // btnfrmMover_Imagen_De_Carpeta_y_Renombrar
            // 
            this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar.Location = new System.Drawing.Point(108, 145);
            this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar.Name = "btnfrmMover_Imagen_De_Carpeta_y_Renombrar";
            this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar.Size = new System.Drawing.Size(303, 23);
            this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar.TabIndex = 3;
            this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar.Text = "Mover Imagen de Carpeta y Renombrar";
            this.toolTip1.SetToolTip(this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar, "Campos obligatorios excel: path_viejo / path_nuevo");
            this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar.UseVisualStyleBackColor = true;
            this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar.Click += new System.EventHandler(this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(32, 24);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 17);
            this.lblMarca.TabIndex = 32;
            this.lblMarca.Text = "Archivo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Firebrick;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(429, 13);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 39);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtArchivoExcel
            // 
            this.txtArchivoExcel.Enabled = false;
            this.txtArchivoExcel.Location = new System.Drawing.Point(108, 21);
            this.txtArchivoExcel.Name = "txtArchivoExcel";
            this.txtArchivoExcel.ReadOnly = true;
            this.txtArchivoExcel.Size = new System.Drawing.Size(314, 22);
            this.txtArchivoExcel.TabIndex = 30;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 190);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtArchivoExcel);
            this.Controls.Add(this.btnfrmMover_Imagen_De_Carpeta_y_Renombrar);
            this.Controls.Add(this.btnfrm_Existe_Imagen_en_carpeta_Imagenes);
            this.Controls.Add(this.btnfrm_Eliminar_Imagen_por_Path);
            this.Controls.Add(this.btnfrm_Descargar_Imagenes_por_URL);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfrm_Descargar_Imagenes_por_URL;
        private System.Windows.Forms.Button btnfrm_Eliminar_Imagen_por_Path;
        private System.Windows.Forms.Button btnfrm_Existe_Imagen_en_carpeta_Imagenes;
        private System.Windows.Forms.Button btnfrmMover_Imagen_De_Carpeta_y_Renombrar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtArchivoExcel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}