﻿namespace WINformulacion
{
    partial class Frm_ActualizaFormulacion_Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ActualizaFormulacion_Personal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Mnu_Proyecto = new System.Windows.Forms.ToolStripDropDownButton();
            this.Btn_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Ayuda = new System.Windows.Forms.ToolStripDropDownButton();
            this.Btn_BuscaClasificador = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_DistribuyeLineaFormulada = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Pegar = new System.Windows.Forms.ToolStripButton();
            this.spreadsheetFormulaBar1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Lbl_Mensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Ayuda = new System.Windows.Forms.ToolStripStatusLabel();
            this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Proyecto,
            this.toolStripSeparator1,
            this.Mnu_Ayuda,
            this.toolStripSeparator2,
            this.Btn_Pegar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Mnu_Proyecto
            // 
            this.Mnu_Proyecto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Nuevo,
            this.Btn_Guardar,
            this.toolStripMenuItem1,
            this.Btn_Imprimir});
            this.Mnu_Proyecto.Image = ((System.Drawing.Image)(resources.GetObject("Mnu_Proyecto.Image")));
            this.Mnu_Proyecto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mnu_Proyecto.Name = "Mnu_Proyecto";
            this.Mnu_Proyecto.Size = new System.Drawing.Size(81, 36);
            this.Mnu_Proyecto.Text = "Personal";
            this.Mnu_Proyecto.Click += new System.EventHandler(this.Mnu_Proyecto_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.Image")));
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(206, 22);
            this.Btn_Nuevo.Text = "&Nueva Formulación";
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Enabled = false;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(206, 22);
            this.Btn_Guardar.Text = "&Guardar Formulación";
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Enabled = false;
            this.Btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Imprimir.Image")));
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(206, 22);
            this.Btn_Imprimir.Text = "Im&primir Hoja de Trabajo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // Mnu_Ayuda
            // 
            this.Mnu_Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_BuscaClasificador,
            this.toolStripSeparator3,
            this.Btn_DistribuyeLineaFormulada,
            this.toolStripSeparator4});
            this.Mnu_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Mnu_Ayuda.Image")));
            this.Mnu_Ayuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mnu_Ayuda.Name = "Mnu_Ayuda";
            this.Mnu_Ayuda.Size = new System.Drawing.Size(70, 36);
            this.Mnu_Ayuda.Text = "Ayuda";
            // 
            // Btn_BuscaClasificador
            // 
            this.Btn_BuscaClasificador.Enabled = false;
            this.Btn_BuscaClasificador.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BuscaClasificador.Image")));
            this.Btn_BuscaClasificador.Name = "Btn_BuscaClasificador";
            this.Btn_BuscaClasificador.Size = new System.Drawing.Size(213, 22);
            this.Btn_BuscaClasificador.Text = "&Buscar Clasificador";
            this.Btn_BuscaClasificador.Click += new System.EventHandler(this.Btn_BuscaClasificador_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // Btn_DistribuyeLineaFormulada
            // 
            this.Btn_DistribuyeLineaFormulada.Enabled = false;
            this.Btn_DistribuyeLineaFormulada.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DistribuyeLineaFormulada.Image")));
            this.Btn_DistribuyeLineaFormulada.Name = "Btn_DistribuyeLineaFormulada";
            this.Btn_DistribuyeLineaFormulada.Size = new System.Drawing.Size(213, 22);
            this.Btn_DistribuyeLineaFormulada.Text = "&Distribuir Linea Formulada";
            this.Btn_DistribuyeLineaFormulada.Click += new System.EventHandler(this.Btn_DistribuyeLineaFormulada_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(210, 6);
            this.toolStripSeparator4.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // Btn_Pegar
            // 
            this.Btn_Pegar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Pegar.Image")));
            this.Btn_Pegar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Pegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Pegar.Name = "Btn_Pegar";
            this.Btn_Pegar.Size = new System.Drawing.Size(73, 36);
            this.Btn_Pegar.Text = "Pegar";
            this.Btn_Pegar.Visible = false;
            this.Btn_Pegar.Click += new System.EventHandler(this.Btn_Pegar_Click);
            // 
            // spreadsheetFormulaBar1
            // 
            this.spreadsheetFormulaBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spreadsheetFormulaBar1.Location = new System.Drawing.Point(0, 39);
            this.spreadsheetFormulaBar1.MinimumSize = new System.Drawing.Size(0, 24);
            this.spreadsheetFormulaBar1.Name = "spreadsheetFormulaBar1";
            this.spreadsheetFormulaBar1.Size = new System.Drawing.Size(800, 24);
            this.spreadsheetFormulaBar1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_Mensaje,
            this.Lbl_Ayuda});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Lbl_Mensaje
            // 
            this.Lbl_Mensaje.Name = "Lbl_Mensaje";
            this.Lbl_Mensaje.Size = new System.Drawing.Size(0, 17);
            // 
            // Lbl_Ayuda
            // 
            this.Lbl_Ayuda.Name = "Lbl_Ayuda";
            this.Lbl_Ayuda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Ayuda.Size = new System.Drawing.Size(67, 17);
            this.Lbl_Ayuda.Text = "F11- Ayuda";
            this.Lbl_Ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spreadsheetControl
            // 
            this.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl.Location = new System.Drawing.Point(0, 63);
            this.spreadsheetControl.Name = "spreadsheetControl";
            this.spreadsheetControl.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl.Options.Import.Csv.Encoding")));
            this.spreadsheetControl.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl.Options.Import.Txt.Encoding")));
            this.spreadsheetControl.Size = new System.Drawing.Size(800, 365);
            this.spreadsheetControl.TabIndex = 7;
            this.spreadsheetControl.Text = "spreadsheetControl1";
            this.spreadsheetControl.SelectionChanged += new System.EventHandler(this.spreadsheetControl_SelectionChanged);
            this.spreadsheetControl.CellBeginEdit += new DevExpress.XtraSpreadsheet.CellBeginEditEventHandler(this.spreadsheetControl_CellBeginEdit);
            this.spreadsheetControl.RowsRemoving += new DevExpress.Spreadsheet.RowsChangingEventHandler(this.spreadsheetControl_RowsRemoving);
            this.spreadsheetControl.RangeCopying += new DevExpress.Spreadsheet.RangeCopyingEventHandler(this.spreadsheetControl_RangeCopying);
            this.spreadsheetControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.spreadsheetControl_KeyUp);
            // 
            // Frm_ActualizaFormulacion_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spreadsheetControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.spreadsheetFormulaBar1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_ActualizaFormulacion_Personal";
            this.ShowIcon = false;
            this.Text = "Gastos del Personal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton Mnu_Proyecto;
        private System.Windows.Forms.ToolStripMenuItem Btn_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem Btn_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Btn_Imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar spreadsheetFormulaBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Btn_Pegar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl;
        private System.Windows.Forms.ToolStripDropDownButton Mnu_Ayuda;
        private System.Windows.Forms.ToolStripMenuItem Btn_BuscaClasificador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Btn_DistribuyeLineaFormulada;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Mensaje;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Ayuda;
    }
}