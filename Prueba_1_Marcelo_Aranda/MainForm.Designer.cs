/*
 * Created by SharpDevelop.
 * User: Marce
 * Date: 8/23/2018
 * Time: 4:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prueba_1_Marcelo_Aranda
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNombreCienSerVivo;
		private System.Windows.Forms.Label lblLapsoDeVidaSerVivo;
		private System.Windows.Forms.TextBox txtSerVivoNombre;
		private System.Windows.Forms.TextBox txtLapsoDeVidaSerVivo;
		private System.Windows.Forms.Button btnRegistrarSerVivo;
		private System.Windows.Forms.Label lblNombCienMicrobio;
		private System.Windows.Forms.Label lblLapsoDeVidaMicrobio;
		private System.Windows.Forms.TextBox txtNombreMicrobio;
		private System.Windows.Forms.TextBox txtLapsoDeVidaMicrobio;
		private System.Windows.Forms.Label lblAnioDescubrim;
		private System.Windows.Forms.Label lblResponsable;
		private System.Windows.Forms.TextBox txtAnioDescubrimiento;
		private System.Windows.Forms.TextBox txtResponsableDe;
		private System.Windows.Forms.Button btnRegistrarMicrobio;
		private System.Windows.Forms.ComboBox cboSeresVivos;
		private System.Windows.Forms.ComboBox cboMicrobios;
		private System.Windows.Forms.Button btnBorrarSerVivo;
		private System.Windows.Forms.Button btnBorrarMicrobio;
		private System.Windows.Forms.Button btnActualizarSerVivo;
		private System.Windows.Forms.Button btnActualizarMicrobio;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNombreCienSerVivo = new System.Windows.Forms.Label();
			this.lblLapsoDeVidaSerVivo = new System.Windows.Forms.Label();
			this.txtSerVivoNombre = new System.Windows.Forms.TextBox();
			this.txtLapsoDeVidaSerVivo = new System.Windows.Forms.TextBox();
			this.btnRegistrarSerVivo = new System.Windows.Forms.Button();
			this.lblNombCienMicrobio = new System.Windows.Forms.Label();
			this.lblLapsoDeVidaMicrobio = new System.Windows.Forms.Label();
			this.txtNombreMicrobio = new System.Windows.Forms.TextBox();
			this.txtLapsoDeVidaMicrobio = new System.Windows.Forms.TextBox();
			this.lblAnioDescubrim = new System.Windows.Forms.Label();
			this.lblResponsable = new System.Windows.Forms.Label();
			this.txtAnioDescubrimiento = new System.Windows.Forms.TextBox();
			this.txtResponsableDe = new System.Windows.Forms.TextBox();
			this.btnRegistrarMicrobio = new System.Windows.Forms.Button();
			this.cboSeresVivos = new System.Windows.Forms.ComboBox();
			this.cboMicrobios = new System.Windows.Forms.ComboBox();
			this.btnBorrarSerVivo = new System.Windows.Forms.Button();
			this.btnBorrarMicrobio = new System.Windows.Forms.Button();
			this.btnActualizarSerVivo = new System.Windows.Forms.Button();
			this.btnActualizarMicrobio = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNombreCienSerVivo
			// 
			this.lblNombreCienSerVivo.Location = new System.Drawing.Point(1, 20);
			this.lblNombreCienSerVivo.Name = "lblNombreCienSerVivo";
			this.lblNombreCienSerVivo.Size = new System.Drawing.Size(100, 23);
			this.lblNombreCienSerVivo.TabIndex = 0;
			this.lblNombreCienSerVivo.Text = "Nombre cientifico: ";
			// 
			// lblLapsoDeVidaSerVivo
			// 
			this.lblLapsoDeVidaSerVivo.Location = new System.Drawing.Point(1, 51);
			this.lblLapsoDeVidaSerVivo.Name = "lblLapsoDeVidaSerVivo";
			this.lblLapsoDeVidaSerVivo.Size = new System.Drawing.Size(120, 23);
			this.lblLapsoDeVidaSerVivo.TabIndex = 1;
			this.lblLapsoDeVidaSerVivo.Text = "Lapso de vida en anios:";
			// 
			// txtSerVivoNombre
			// 
			this.txtSerVivoNombre.Location = new System.Drawing.Point(127, 17);
			this.txtSerVivoNombre.Name = "txtSerVivoNombre";
			this.txtSerVivoNombre.Size = new System.Drawing.Size(100, 20);
			this.txtSerVivoNombre.TabIndex = 2;
			// 
			// txtLapsoDeVidaSerVivo
			// 
			this.txtLapsoDeVidaSerVivo.Location = new System.Drawing.Point(127, 51);
			this.txtLapsoDeVidaSerVivo.Name = "txtLapsoDeVidaSerVivo";
			this.txtLapsoDeVidaSerVivo.Size = new System.Drawing.Size(100, 20);
			this.txtLapsoDeVidaSerVivo.TabIndex = 3;
			// 
			// btnRegistrarSerVivo
			// 
			this.btnRegistrarSerVivo.Location = new System.Drawing.Point(61, 91);
			this.btnRegistrarSerVivo.Name = "btnRegistrarSerVivo";
			this.btnRegistrarSerVivo.Size = new System.Drawing.Size(105, 23);
			this.btnRegistrarSerVivo.TabIndex = 4;
			this.btnRegistrarSerVivo.Text = "Registrar ser vivo";
			this.btnRegistrarSerVivo.UseVisualStyleBackColor = true;
			this.btnRegistrarSerVivo.Click += new System.EventHandler(this.BtnRegistrarSerVivoClick);
			// 
			// lblNombCienMicrobio
			// 
			this.lblNombCienMicrobio.Location = new System.Drawing.Point(443, 20);
			this.lblNombCienMicrobio.Name = "lblNombCienMicrobio";
			this.lblNombCienMicrobio.Size = new System.Drawing.Size(100, 23);
			this.lblNombCienMicrobio.TabIndex = 5;
			this.lblNombCienMicrobio.Text = "Nombre cientifico: ";
			// 
			// lblLapsoDeVidaMicrobio
			// 
			this.lblLapsoDeVidaMicrobio.Location = new System.Drawing.Point(443, 51);
			this.lblLapsoDeVidaMicrobio.Name = "lblLapsoDeVidaMicrobio";
			this.lblLapsoDeVidaMicrobio.Size = new System.Drawing.Size(126, 23);
			this.lblLapsoDeVidaMicrobio.TabIndex = 6;
			this.lblLapsoDeVidaMicrobio.Text = "Lapso de vida en anios:";
			// 
			// txtNombreMicrobio
			// 
			this.txtNombreMicrobio.Location = new System.Drawing.Point(566, 20);
			this.txtNombreMicrobio.Name = "txtNombreMicrobio";
			this.txtNombreMicrobio.Size = new System.Drawing.Size(100, 20);
			this.txtNombreMicrobio.TabIndex = 7;
			// 
			// txtLapsoDeVidaMicrobio
			// 
			this.txtLapsoDeVidaMicrobio.Location = new System.Drawing.Point(566, 54);
			this.txtLapsoDeVidaMicrobio.Name = "txtLapsoDeVidaMicrobio";
			this.txtLapsoDeVidaMicrobio.Size = new System.Drawing.Size(100, 20);
			this.txtLapsoDeVidaMicrobio.TabIndex = 8;
			// 
			// lblAnioDescubrim
			// 
			this.lblAnioDescubrim.Location = new System.Drawing.Point(446, 91);
			this.lblAnioDescubrim.Name = "lblAnioDescubrim";
			this.lblAnioDescubrim.Size = new System.Drawing.Size(123, 23);
			this.lblAnioDescubrim.TabIndex = 9;
			this.lblAnioDescubrim.Text = "Anio de descubrimiento:";
			// 
			// lblResponsable
			// 
			this.lblResponsable.Location = new System.Drawing.Point(446, 134);
			this.lblResponsable.Name = "lblResponsable";
			this.lblResponsable.Size = new System.Drawing.Size(100, 23);
			this.lblResponsable.TabIndex = 10;
			this.lblResponsable.Text = "Responsable de: ";
			// 
			// txtAnioDescubrimiento
			// 
			this.txtAnioDescubrimiento.Location = new System.Drawing.Point(566, 88);
			this.txtAnioDescubrimiento.Name = "txtAnioDescubrimiento";
			this.txtAnioDescubrimiento.Size = new System.Drawing.Size(100, 20);
			this.txtAnioDescubrimiento.TabIndex = 11;
			// 
			// txtResponsableDe
			// 
			this.txtResponsableDe.Location = new System.Drawing.Point(566, 134);
			this.txtResponsableDe.Name = "txtResponsableDe";
			this.txtResponsableDe.Size = new System.Drawing.Size(100, 20);
			this.txtResponsableDe.TabIndex = 12;
			// 
			// btnRegistrarMicrobio
			// 
			this.btnRegistrarMicrobio.Location = new System.Drawing.Point(523, 189);
			this.btnRegistrarMicrobio.Name = "btnRegistrarMicrobio";
			this.btnRegistrarMicrobio.Size = new System.Drawing.Size(118, 23);
			this.btnRegistrarMicrobio.TabIndex = 13;
			this.btnRegistrarMicrobio.Text = "Registrar microbio";
			this.btnRegistrarMicrobio.UseVisualStyleBackColor = true;
			this.btnRegistrarMicrobio.Click += new System.EventHandler(this.BtnRegistrarMicrobioClick);
			// 
			// cboSeresVivos
			// 
			this.cboSeresVivos.FormattingEnabled = true;
			this.cboSeresVivos.Location = new System.Drawing.Point(247, 16);
			this.cboSeresVivos.Name = "cboSeresVivos";
			this.cboSeresVivos.Size = new System.Drawing.Size(121, 21);
			this.cboSeresVivos.TabIndex = 14;
			this.cboSeresVivos.SelectedIndexChanged += new System.EventHandler(this.CboSeresVivosSelectedIndexChanged);
			// 
			// cboMicrobios
			// 
			this.cboMicrobios.FormattingEnabled = true;
			this.cboMicrobios.Location = new System.Drawing.Point(675, 20);
			this.cboMicrobios.Name = "cboMicrobios";
			this.cboMicrobios.Size = new System.Drawing.Size(121, 21);
			this.cboMicrobios.TabIndex = 15;
			this.cboMicrobios.SelectedIndexChanged += new System.EventHandler(this.CboMicrobiosSelectedIndexChanged);
			// 
			// btnBorrarSerVivo
			// 
			this.btnBorrarSerVivo.Location = new System.Drawing.Point(61, 129);
			this.btnBorrarSerVivo.Name = "btnBorrarSerVivo";
			this.btnBorrarSerVivo.Size = new System.Drawing.Size(105, 23);
			this.btnBorrarSerVivo.TabIndex = 16;
			this.btnBorrarSerVivo.Text = "Borrar ser vivo";
			this.btnBorrarSerVivo.UseVisualStyleBackColor = true;
			this.btnBorrarSerVivo.Click += new System.EventHandler(this.BtnBorrarSerVivoClick);
			// 
			// btnBorrarMicrobio
			// 
			this.btnBorrarMicrobio.Location = new System.Drawing.Point(523, 227);
			this.btnBorrarMicrobio.Name = "btnBorrarMicrobio";
			this.btnBorrarMicrobio.Size = new System.Drawing.Size(118, 23);
			this.btnBorrarMicrobio.TabIndex = 17;
			this.btnBorrarMicrobio.Text = "Borrar microbio";
			this.btnBorrarMicrobio.UseVisualStyleBackColor = true;
			this.btnBorrarMicrobio.Click += new System.EventHandler(this.BtnBorrarMicrobioClick);
			// 
			// btnActualizarSerVivo
			// 
			this.btnActualizarSerVivo.Location = new System.Drawing.Point(61, 168);
			this.btnActualizarSerVivo.Name = "btnActualizarSerVivo";
			this.btnActualizarSerVivo.Size = new System.Drawing.Size(105, 23);
			this.btnActualizarSerVivo.TabIndex = 18;
			this.btnActualizarSerVivo.Text = "Actualizar ser vivo";
			this.btnActualizarSerVivo.UseVisualStyleBackColor = true;
			this.btnActualizarSerVivo.Click += new System.EventHandler(this.BtnActualizarSerVivoClick);
			// 
			// btnActualizarMicrobio
			// 
			this.btnActualizarMicrobio.Location = new System.Drawing.Point(523, 268);
			this.btnActualizarMicrobio.Name = "btnActualizarMicrobio";
			this.btnActualizarMicrobio.Size = new System.Drawing.Size(118, 23);
			this.btnActualizarMicrobio.TabIndex = 19;
			this.btnActualizarMicrobio.Text = "Actualizar microbio";
			this.btnActualizarMicrobio.UseVisualStyleBackColor = true;
			this.btnActualizarMicrobio.Click += new System.EventHandler(this.BtnActualizarMicrobioClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 327);
			this.Controls.Add(this.btnActualizarMicrobio);
			this.Controls.Add(this.btnActualizarSerVivo);
			this.Controls.Add(this.btnBorrarMicrobio);
			this.Controls.Add(this.btnBorrarSerVivo);
			this.Controls.Add(this.cboMicrobios);
			this.Controls.Add(this.cboSeresVivos);
			this.Controls.Add(this.btnRegistrarMicrobio);
			this.Controls.Add(this.txtResponsableDe);
			this.Controls.Add(this.txtAnioDescubrimiento);
			this.Controls.Add(this.lblResponsable);
			this.Controls.Add(this.lblAnioDescubrim);
			this.Controls.Add(this.txtLapsoDeVidaMicrobio);
			this.Controls.Add(this.txtNombreMicrobio);
			this.Controls.Add(this.lblLapsoDeVidaMicrobio);
			this.Controls.Add(this.lblNombCienMicrobio);
			this.Controls.Add(this.btnRegistrarSerVivo);
			this.Controls.Add(this.txtLapsoDeVidaSerVivo);
			this.Controls.Add(this.txtSerVivoNombre);
			this.Controls.Add(this.lblLapsoDeVidaSerVivo);
			this.Controls.Add(this.lblNombreCienSerVivo);
			this.Name = "MainForm";
			this.Text = "Menu Principal";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
