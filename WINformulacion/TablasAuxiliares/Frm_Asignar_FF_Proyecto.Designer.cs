﻿namespace WINformulacion
{
    partial class Frm_Asignar_FF_Proyecto
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook2 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Asignar_FF_Proyecto));
            this.btnQuitar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.Grd_mvto_FFAsignados = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Grd_mvto_FFXAsignar = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_NomProyecto = new gnUserControl.gnTextBox_Simple();
            this.Txt_Proyecto = new gnUserControl.gnTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_FFAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_FFXAsignar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NomProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Proyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(363, 277);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 8;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(363, 217);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.Grd_mvto_FFAsignados);
            this.groupControl3.Location = new System.Drawing.Point(447, 99);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(340, 330);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Fuente de Financiamiento Asignados";
            // 
            // Grd_mvto_FFAsignados
            // 
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            this.Grd_mvto_FFAsignados.DisplayLayout.Appearance = Appearance1;
            this.Grd_mvto_FFAsignados.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.Transparent;
            this.Grd_mvto_FFAsignados.DisplayLayout.Override.CardAreaAppearance = Appearance2;
            this.Grd_mvto_FFAsignados.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            Appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance3.ForeColor = System.Drawing.Color.Black;
            Appearance3.TextHAlignAsString = "Left";
            Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_mvto_FFAsignados.DisplayLayout.Override.HeaderAppearance = Appearance3;
            this.Grd_mvto_FFAsignados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            Appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_mvto_FFAsignados.DisplayLayout.Override.RowAppearance = Appearance4;
            Appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_mvto_FFAsignados.DisplayLayout.Override.RowSelectorAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance6.ForeColor = System.Drawing.Color.Black;
            this.Grd_mvto_FFAsignados.DisplayLayout.Override.SelectedRowAppearance = Appearance6;
            this.Grd_mvto_FFAsignados.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_mvto_FFAsignados.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            scrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            scrollBarLook1.ShowMinMaxButtons = Infragistics.Win.DefaultableBoolean.True;
            this.Grd_mvto_FFAsignados.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.Grd_mvto_FFAsignados.DisplayLayout.UseFixedHeaders = true;
            this.Grd_mvto_FFAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_mvto_FFAsignados.Location = new System.Drawing.Point(2, 20);
            this.Grd_mvto_FFAsignados.Name = "Grd_mvto_FFAsignados";
            this.Grd_mvto_FFAsignados.Size = new System.Drawing.Size(336, 308);
            this.Grd_mvto_FFAsignados.TabIndex = 56;
            this.Grd_mvto_FFAsignados.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_mvto_FFAsignados_InitializeLayout);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Grd_mvto_FFXAsignar);
            this.groupControl2.Location = new System.Drawing.Point(14, 99);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(340, 331);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Fuente de Financiamiento por Asignar";
            // 
            // Grd_mvto_FFXAsignar
            // 
            appearance1.BackColor = System.Drawing.Color.Transparent;
            this.Grd_mvto_FFXAsignar.DisplayLayout.Appearance = appearance1;
            this.Grd_mvto_FFXAsignar.DisplayLayout.InterBandSpacing = 10;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.Grd_mvto_FFXAsignar.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.Grd_mvto_FFXAsignar.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.ForeColor = System.Drawing.Color.Black;
            appearance3.TextHAlignAsString = "Left";
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_mvto_FFXAsignar.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.Grd_mvto_FFXAsignar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_mvto_FFXAsignar.DisplayLayout.Override.RowAppearance = appearance4;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_mvto_FFXAsignar.DisplayLayout.Override.RowSelectorAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.Color.Black;
            this.Grd_mvto_FFXAsignar.DisplayLayout.Override.SelectedRowAppearance = appearance6;
            this.Grd_mvto_FFXAsignar.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_mvto_FFXAsignar.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            scrollBarLook2.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            scrollBarLook2.ShowMinMaxButtons = Infragistics.Win.DefaultableBoolean.True;
            this.Grd_mvto_FFXAsignar.DisplayLayout.ScrollBarLook = scrollBarLook2;
            this.Grd_mvto_FFXAsignar.DisplayLayout.UseFixedHeaders = true;
            this.Grd_mvto_FFXAsignar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_mvto_FFXAsignar.Location = new System.Drawing.Point(2, 20);
            this.Grd_mvto_FFXAsignar.Name = "Grd_mvto_FFXAsignar";
            this.Grd_mvto_FFXAsignar.Size = new System.Drawing.Size(336, 309);
            this.Grd_mvto_FFXAsignar.TabIndex = 55;
            this.Grd_mvto_FFXAsignar.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_mvto_FFXAsignar_InitializeLayout);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnBuscar);
            this.groupControl1.Controls.Add(this.Txt_NomProyecto);
            this.groupControl1.Controls.Add(this.Txt_Proyecto);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(774, 66);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(635, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Txt_NomProyecto
            // 
            this.Txt_NomProyecto.Enabled = false;
            this.Txt_NomProyecto.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_NomProyecto.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_NomProyecto.exigirCampoLleno = false;
            this.Txt_NomProyecto.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_NomProyecto.Location = new System.Drawing.Point(222, 23);
            this.Txt_NomProyecto.LongitudTexto = 200;
            this.Txt_NomProyecto.Name = "Txt_NomProyecto";
            this.Txt_NomProyecto.resaltarCampoOmitido = false;
            this.Txt_NomProyecto.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_NomProyecto.Size = new System.Drawing.Size(407, 22);
            this.Txt_NomProyecto.TabIndex = 94;
            this.Txt_NomProyecto.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.Txt_NomProyecto.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // Txt_Proyecto
            // 
            this.Txt_Proyecto.anchoColumnasAyuda = "150, 210, 210";
            this.Txt_Proyecto.DatoAnterior = "";
            this.Txt_Proyecto.EligevariosElementos = false;
            this.Txt_Proyecto.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_Proyecto.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_Proyecto.exigirCampoLleno = false;
            this.Txt_Proyecto.InputMask = "";
            this.Txt_Proyecto.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_Proyecto.Location = new System.Drawing.Point(113, 23);
            this.Txt_Proyecto.LongitudTexto = 200;
            this.Txt_Proyecto.mensajeExisteDatoSP = "";
            this.Txt_Proyecto.mensajeNoExisteDatoSP = "";
            this.Txt_Proyecto.Name = "Txt_Proyecto";
            this.Txt_Proyecto.nombreDS = null;
            this.Txt_Proyecto.nombreExisteDatoSP = "";
            this.Txt_Proyecto.nombreNoExisteDatoSP = "";
            this.Txt_Proyecto.nombreSP = "";
            this.Txt_Proyecto.parametrosExisteDatoSP = "";
            this.Txt_Proyecto.parametrosNoExisteDatoSP = "";
            this.Txt_Proyecto.parametrosSP = "";
            this.Txt_Proyecto.PosicionCampo = 0;
            this.Txt_Proyecto.PosicionCampoTexto = 1;
            this.Txt_Proyecto.PosicionValue = 0;
            this.Txt_Proyecto.resaltarCampoOmitido = false;
            this.Txt_Proyecto.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_Proyecto.Size = new System.Drawing.Size(103, 22);
            this.Txt_Proyecto.TabIndex = 1;
            this.Txt_Proyecto.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_Proyecto.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_Proyecto.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_Proyecto.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_Proyecto.valorDevueltoVarios = "";
            this.Txt_Proyecto.ValorDigitado = "";
            this.Txt_Proyecto.Leave += new System.EventHandler(this.Txt_Proyecto_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(60, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Proyecto:";
            // 
            // Frm_Asignar_FF_Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Name = "Frm_Asignar_FF_Proyecto";
            this.ShowIcon = false;
            this.Text = "Asignar Fuente Financiamiento a Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_FFAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_FFXAsignar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NomProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Proyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnQuitar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_mvto_FFAsignados;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_mvto_FFXAsignar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private gnUserControl.gnTextBox_Simple Txt_NomProyecto;
        private gnUserControl.gnTextBox Txt_Proyecto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}