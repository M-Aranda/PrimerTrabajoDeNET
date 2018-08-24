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
		private System.Windows.Forms.Label lblNomCient;
		private System.Windows.Forms.TextBox txtNomCien;
		
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
			this.lblNomCient = new System.Windows.Forms.Label();
			this.txtNomCien = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblNomCient
			// 
			this.lblNomCient.Location = new System.Drawing.Point(31, 41);
			this.lblNomCient.Name = "lblNomCient";
			this.lblNomCient.Size = new System.Drawing.Size(92, 23);
			this.lblNomCient.TabIndex = 0;
			this.lblNomCient.Text = "Nombre cientifico: ";
			// 
			// txtNomCien
			// 
			this.txtNomCien.Location = new System.Drawing.Point(129, 41);
			this.txtNomCien.Name = "txtNomCien";
			this.txtNomCien.Size = new System.Drawing.Size(121, 20);
			this.txtNomCien.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 261);
			this.Controls.Add(this.txtNomCien);
			this.Controls.Add(this.lblNomCient);
			this.Name = "MainForm";
			this.Text = "Menu Principal";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
