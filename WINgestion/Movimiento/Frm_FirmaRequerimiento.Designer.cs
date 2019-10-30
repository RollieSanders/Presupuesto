namespace WINgestion
{
    partial class Frm_FirmaRequerimiento
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
            Infragistics.Win.Appearance Appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FirmaRequerimiento));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grd_Buscados = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.opt_ConAutorizacion = new System.Windows.Forms.RadioButton();
            this.opt_SinAutorizacion = new System.Windows.Forms.RadioButton();
            this.Crv_Requerimiento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.UltraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Btn_Descartar = new Infragistics.Win.Misc.UltraButton();
            this.Btn_FirmaDigital = new Infragistics.Win.Misc.UltraButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Exportar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).BeginInit();
            this.UltraGroupBox1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox2.Controls.Add(this.splitContainer1);
            this.UltraGroupBox2.Controls.Add(this.ToolStrip1);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(1016, 450);
            this.UltraGroupBox2.TabIndex = 8;
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(1, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Grd_Buscados);
            this.splitContainer1.Panel1.Controls.Add(this.UltraGroupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Crv_Requerimiento);
            this.splitContainer1.Panel2.Controls.Add(this.UltraGroupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1014, 424);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 2;
            // 
            // Grd_Buscados
            // 
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            this.Grd_Buscados.DisplayLayout.Appearance = Appearance1;
            this.Grd_Buscados.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.Transparent;
            this.Grd_Buscados.DisplayLayout.Override.CardAreaAppearance = Appearance2;
            this.Grd_Buscados.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            Appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance3.ForeColor = System.Drawing.Color.Black;
            Appearance3.TextHAlignAsString = "Left";
            Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_Buscados.DisplayLayout.Override.HeaderAppearance = Appearance3;
            this.Grd_Buscados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            Appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_Buscados.DisplayLayout.Override.RowAppearance = Appearance4;
            Appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_Buscados.DisplayLayout.Override.RowSelectorAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance6.ForeColor = System.Drawing.Color.Black;
            this.Grd_Buscados.DisplayLayout.Override.SelectedRowAppearance = Appearance6;
            this.Grd_Buscados.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_Buscados.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            scrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            scrollBarLook1.ShowMinMaxButtons = Infragistics.Win.DefaultableBoolean.True;
            this.Grd_Buscados.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.Grd_Buscados.DisplayLayout.UseFixedHeaders = true;
            this.Grd_Buscados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Buscados.Location = new System.Drawing.Point(0, 0);
            this.Grd_Buscados.Name = "Grd_Buscados";
            this.Grd_Buscados.Size = new System.Drawing.Size(337, 370);
            this.Grd_Buscados.TabIndex = 55;
            this.Grd_Buscados.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_Buscados_InitializeLayout);
            this.Grd_Buscados.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.Grd_Buscados_AfterSelectChange);
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.Controls.Add(this.opt_ConAutorizacion);
            this.UltraGroupBox3.Controls.Add(this.opt_SinAutorizacion);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UltraGroupBox3.Location = new System.Drawing.Point(0, 370);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(337, 50);
            this.UltraGroupBox3.TabIndex = 14;
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // opt_ConAutorizacion
            // 
            this.opt_ConAutorizacion.AutoSize = true;
            this.opt_ConAutorizacion.BackColor = System.Drawing.Color.Transparent;
            this.opt_ConAutorizacion.Location = new System.Drawing.Point(112, 17);
            this.opt_ConAutorizacion.Name = "opt_ConAutorizacion";
            this.opt_ConAutorizacion.Size = new System.Drawing.Size(105, 17);
            this.opt_ConAutorizacion.TabIndex = 3;
            this.opt_ConAutorizacion.Text = "Con Autorización";
            this.opt_ConAutorizacion.UseVisualStyleBackColor = false;
            this.opt_ConAutorizacion.CheckedChanged += new System.EventHandler(this.opt_ConAutorizacion_CheckedChanged);
            // 
            // opt_SinAutorizacion
            // 
            this.opt_SinAutorizacion.AutoSize = true;
            this.opt_SinAutorizacion.BackColor = System.Drawing.Color.Transparent;
            this.opt_SinAutorizacion.Checked = true;
            this.opt_SinAutorizacion.Location = new System.Drawing.Point(6, 17);
            this.opt_SinAutorizacion.Name = "opt_SinAutorizacion";
            this.opt_SinAutorizacion.Size = new System.Drawing.Size(101, 17);
            this.opt_SinAutorizacion.TabIndex = 2;
            this.opt_SinAutorizacion.TabStop = true;
            this.opt_SinAutorizacion.Text = "Sin Autorización";
            this.opt_SinAutorizacion.UseVisualStyleBackColor = false;
            this.opt_SinAutorizacion.CheckedChanged += new System.EventHandler(this.opt_SinAutorizacion_CheckedChanged);
            // 
            // Crv_Requerimiento
            // 
            this.Crv_Requerimiento.ActiveViewIndex = -1;
            this.Crv_Requerimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_Requerimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_Requerimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_Requerimiento.Location = new System.Drawing.Point(0, 0);
            this.Crv_Requerimiento.Name = "Crv_Requerimiento";
            this.Crv_Requerimiento.ShowGroupTreeButton = false;
            this.Crv_Requerimiento.Size = new System.Drawing.Size(665, 376);
            this.Crv_Requerimiento.TabIndex = 16;
            this.Crv_Requerimiento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.Crv_Requerimiento.Visible = false;
            // 
            // UltraGroupBox1
            // 
            this.UltraGroupBox1.Controls.Add(this.Btn_Descartar);
            this.UltraGroupBox1.Controls.Add(this.Btn_FirmaDigital);
            this.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UltraGroupBox1.Location = new System.Drawing.Point(0, 376);
            this.UltraGroupBox1.Name = "UltraGroupBox1";
            this.UltraGroupBox1.Size = new System.Drawing.Size(665, 44);
            this.UltraGroupBox1.TabIndex = 15;
            this.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Btn_Descartar
            // 
            this.Btn_Descartar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            appearance1.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance1.Image = ((object)(resources.GetObject("appearance1.Image")));
            appearance1.ImageHAlign = Infragistics.Win.HAlign.Left;
            this.Btn_Descartar.Appearance = appearance1;
            this.Btn_Descartar.Location = new System.Drawing.Point(6, 9);
            this.Btn_Descartar.Name = "Btn_Descartar";
            this.Btn_Descartar.Size = new System.Drawing.Size(119, 27);
            this.Btn_Descartar.TabIndex = 6;
            this.Btn_Descartar.Text = "Descartar";
            this.Btn_Descartar.Visible = false;
            this.Btn_Descartar.Click += new System.EventHandler(this.Btn_Descartar_Click);
            // 
            // Btn_FirmaDigital
            // 
            this.Btn_FirmaDigital.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance2.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance2.Image = ((object)(resources.GetObject("appearance2.Image")));
            appearance2.ImageHAlign = Infragistics.Win.HAlign.Right;
            this.Btn_FirmaDigital.Appearance = appearance2;
            this.Btn_FirmaDigital.Location = new System.Drawing.Point(540, 9);
            this.Btn_FirmaDigital.Name = "Btn_FirmaDigital";
            this.Btn_FirmaDigital.Size = new System.Drawing.Size(119, 27);
            this.Btn_FirmaDigital.TabIndex = 5;
            this.Btn_FirmaDigital.Text = "Firmar";
            this.Btn_FirmaDigital.Visible = false;
            this.Btn_FirmaDigital.Click += new System.EventHandler(this.btn_FirmaDigital_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(1, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1014, 25);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(54, 22);
            this.btn_Exportar.Text = "Exportar";
            // 
            // Frm_FirmaRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.UltraGroupBox2);
            this.Name = "Frm_FirmaRequerimiento";
            this.Text = "Firmar Requerimiento";
            this.Load += new System.EventHandler(this.Frm_FirmaRequerimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            this.UltraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).EndInit();
            this.UltraGroupBox1.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btn_Exportar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal System.Windows.Forms.RadioButton opt_ConAutorizacion;
        internal System.Windows.Forms.RadioButton opt_SinAutorizacion;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox1;
        internal Infragistics.Win.Misc.UltraButton Btn_FirmaDigital;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_Requerimiento;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_Buscados;
        internal Infragistics.Win.Misc.UltraButton Btn_Descartar;
    }
}