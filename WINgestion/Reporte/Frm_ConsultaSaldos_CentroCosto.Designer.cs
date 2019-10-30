namespace WINgestion
{
    partial class Frm_ConsultaSaldos_CentroCosto
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
            Infragistics.Win.Appearance Appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaSaldos_CentroCosto));
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGroupBox4 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Grd_Saldos = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Exportar = new System.Windows.Forms.ToolStripButton();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.Cbo_AñoProceso = new gnUserControl.gnComboBox();
            this.Txt_CodCentroCosto = new gnUserControl.gnTextBox();
            this.Txt_NomCentroCosto = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.UltraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox4)).BeginInit();
            this.ultraGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Saldos)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodCentroCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NomCentroCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox3.Controls.Add(this.ultraGroupBox4);
            this.UltraGroupBox3.Controls.Add(this.ToolStrip1);
            this.UltraGroupBox3.Controls.Add(this.ultraGroupBox1);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(800, 450);
            this.UltraGroupBox3.TabIndex = 9;
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ultraGroupBox4
            // 
            this.ultraGroupBox4.Controls.Add(this.Grd_Saldos);
            this.ultraGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.ultraGroupBox4.Location = new System.Drawing.Point(1, 94);
            this.ultraGroupBox4.Name = "ultraGroupBox4";
            this.ultraGroupBox4.Size = new System.Drawing.Size(798, 355);
            this.ultraGroupBox4.TabIndex = 17;
            this.ultraGroupBox4.Text = "Ejecución Presupuestal";
            this.ultraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Grd_Saldos
            // 
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            this.Grd_Saldos.DisplayLayout.Appearance = Appearance1;
            this.Grd_Saldos.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.Transparent;
            this.Grd_Saldos.DisplayLayout.Override.CardAreaAppearance = Appearance2;
            this.Grd_Saldos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            Appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance3.ForeColor = System.Drawing.Color.Black;
            Appearance3.TextHAlignAsString = "Left";
            Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_Saldos.DisplayLayout.Override.HeaderAppearance = Appearance3;
            this.Grd_Saldos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            Appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_Saldos.DisplayLayout.Override.RowAppearance = Appearance4;
            Appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_Saldos.DisplayLayout.Override.RowSelectorAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance6.ForeColor = System.Drawing.Color.Black;
            this.Grd_Saldos.DisplayLayout.Override.SelectedRowAppearance = Appearance6;
            this.Grd_Saldos.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_Saldos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            scrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            scrollBarLook1.ShowMinMaxButtons = Infragistics.Win.DefaultableBoolean.True;
            this.Grd_Saldos.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.Grd_Saldos.DisplayLayout.UseFixedHeaders = true;
            this.Grd_Saldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Saldos.Location = new System.Drawing.Point(22, 3);
            this.Grd_Saldos.Name = "Grd_Saldos";
            this.Grd_Saldos.Size = new System.Drawing.Size(773, 349);
            this.Grd_Saldos.TabIndex = 55;
            this.Grd_Saldos.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_Saldos_InitializeLayout);
            this.Grd_Saldos.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.Grd_Saldos_ClickCellButton);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(1, 69);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(798, 25);
            this.ToolStrip1.TabIndex = 10;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // Btn_Exportar
            // 
            this.Btn_Exportar.Image = global::WINgestion.Properties.Resources.Exportar_16x16;
            this.Btn_Exportar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Btn_Exportar.Name = "Btn_Exportar";
            this.Btn_Exportar.Size = new System.Drawing.Size(70, 22);
            this.Btn_Exportar.Text = "Exportar";
            this.Btn_Exportar.Click += new System.EventHandler(this.Btn_Exportar_Click);
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.Btn_Mostrar);
            this.ultraGroupBox1.Controls.Add(this.Cbo_AñoProceso);
            this.ultraGroupBox1.Controls.Add(this.Txt_CodCentroCosto);
            this.ultraGroupBox1.Controls.Add(this.Txt_NomCentroCosto);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel1);
            this.ultraGroupBox1.Controls.Add(this.UltraLabel2);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.ultraGroupBox1.Location = new System.Drawing.Point(1, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(798, 69);
            this.ultraGroupBox1.TabIndex = 9;
            this.ultraGroupBox1.Text = "Filtro";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(712, 37);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mostrar.TabIndex = 116;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // Cbo_AñoProceso
            // 
            this.Cbo_AñoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_AñoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_AñoProceso.FormattingEnabled = true;
            this.Cbo_AñoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_AñoProceso.Location = new System.Drawing.Point(126, 12);
            this.Cbo_AñoProceso.Name = "Cbo_AñoProceso";
            this.Cbo_AñoProceso.nombreDS = null;
            this.Cbo_AñoProceso.nombreSP = "";
            this.Cbo_AñoProceso.parametrosSP = "";
            this.Cbo_AñoProceso.resaltarCampoOmitido = false;
            this.Cbo_AñoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_AñoProceso.Size = new System.Drawing.Size(129, 21);
            this.Cbo_AñoProceso.TabIndex = 115;
            this.Cbo_AñoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.StoredProcedure;
            // 
            // Txt_CodCentroCosto
            // 
            this.Txt_CodCentroCosto.anchoColumnasAyuda = "70, 500";
            this.Txt_CodCentroCosto.DatoAnterior = "";
            this.Txt_CodCentroCosto.EligevariosElementos = false;
            this.Txt_CodCentroCosto.Enabled = false;
            this.Txt_CodCentroCosto.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_CodCentroCosto.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_CodCentroCosto.exigirCampoLleno = false;
            this.Txt_CodCentroCosto.InputMask = null;
            this.Txt_CodCentroCosto.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_CodCentroCosto.Location = new System.Drawing.Point(126, 34);
            this.Txt_CodCentroCosto.LongitudTexto = 200;
            this.Txt_CodCentroCosto.mensajeExisteDatoSP = "";
            this.Txt_CodCentroCosto.mensajeNoExisteDatoSP = "";
            this.Txt_CodCentroCosto.Name = "Txt_CodCentroCosto";
            this.Txt_CodCentroCosto.nombreDS = null;
            this.Txt_CodCentroCosto.nombreExisteDatoSP = "";
            this.Txt_CodCentroCosto.nombreNoExisteDatoSP = "";
            this.Txt_CodCentroCosto.nombreSP = "Formulacion.spp_help_msto_partida";
            this.Txt_CodCentroCosto.parametrosExisteDatoSP = "";
            this.Txt_CodCentroCosto.parametrosNoExisteDatoSP = "";
            this.Txt_CodCentroCosto.parametrosSP = null;
            this.Txt_CodCentroCosto.PosicionCampo = 0;
            this.Txt_CodCentroCosto.PosicionCampoTexto = 1;
            this.Txt_CodCentroCosto.PosicionValue = 0;
            this.Txt_CodCentroCosto.resaltarCampoOmitido = false;
            this.Txt_CodCentroCosto.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_CodCentroCosto.Size = new System.Drawing.Size(129, 21);
            this.Txt_CodCentroCosto.TabIndex = 23;
            this.Txt_CodCentroCosto.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_CodCentroCosto.tipoDato = gnUserControl.gnTextBox.Tipo.Numerico;
            this.Txt_CodCentroCosto.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_CodCentroCosto.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_CodCentroCosto.valorDevueltoVarios = "";
            this.Txt_CodCentroCosto.ValorDigitado = "";
            this.Txt_CodCentroCosto.Leave += new System.EventHandler(this.Txt_CodCentroCosto_Leave);
            // 
            // Txt_NomCentroCosto
            // 
            appearance19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Txt_NomCentroCosto.Appearance = appearance19;
            this.Txt_NomCentroCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Txt_NomCentroCosto.Enabled = false;
            this.Txt_NomCentroCosto.Location = new System.Drawing.Point(263, 34);
            this.Txt_NomCentroCosto.Name = "Txt_NomCentroCosto";
            this.Txt_NomCentroCosto.Size = new System.Drawing.Size(328, 21);
            this.Txt_NomCentroCosto.TabIndex = 25;
            // 
            // ultraLabel1
            // 
            appearance10.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel1.Appearance = appearance10;
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(33, 37);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(90, 14);
            this.ultraLabel1.TabIndex = 24;
            this.ultraLabel1.Text = "Centro de Costo:";
            // 
            // UltraLabel2
            // 
            appearance16.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel2.Appearance = appearance16;
            this.UltraLabel2.AutoSize = true;
            this.UltraLabel2.Location = new System.Drawing.Point(32, 12);
            this.UltraLabel2.Name = "UltraLabel2";
            this.UltraLabel2.Size = new System.Drawing.Size(27, 14);
            this.UltraLabel2.TabIndex = 19;
            this.UltraLabel2.Text = "Año:";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Siguiente.png");
            // 
            // SaveDocumento
            // 
            this.SaveDocumento.DefaultExt = "XLS";
            this.SaveDocumento.Filter = "Excel (*.xls)|*.xls";
            this.SaveDocumento.RestoreDirectory = true;
            // 
            // Frm_ConsultaSaldos_CentroCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UltraGroupBox3);
            this.Name = "Frm_ConsultaSaldos_CentroCosto";
            this.Text = "Saldos por Centro Gestores";
            this.Load += new System.EventHandler(this.Frm_ConsultaSaldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            this.UltraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox4)).EndInit();
            this.ultraGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Saldos)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodCentroCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NomCentroCosto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal gnUserControl.gnTextBox Txt_CodCentroCosto;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor Txt_NomCentroCosto;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel1;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel2;
        private gnUserControl.gnComboBox Cbo_AñoProceso;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Btn_Exportar;
        internal Infragistics.Win.Misc.UltraGroupBox ultraGroupBox4;
        private System.Windows.Forms.Button Btn_Mostrar;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_Saldos;
        private System.Windows.Forms.ImageList imageList2;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
    }
}