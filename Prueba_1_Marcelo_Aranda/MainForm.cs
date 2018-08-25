/*
 * Created by SharpDevelop.
 * User: Marce
 * Date: 8/23/2018
 * Time: 4:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Prueba_1_Marcelo_Aranda.Model;
using Prueba_1_Marcelo_Aranda.DAO;
using System.Collections.Generic;
using System.Linq;


namespace Prueba_1_Marcelo_Aranda
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		DAO_Microbio microbios;
		DAO_SerVivo seresVivos;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			SerVivo humano=new SerVivo();
			SerVivo perro= new SerVivo();
			
			humano.NombreCientifico="Homo Sapiens";
			humano.LapsoDeVidaEnAnios=80;
			perro.NombreCientifico="Canis lupus familiaris";
			perro.LapsoDeVidaEnAnios=15;
			
			seresVivos= new DAO_SerVivo();
			seresVivos.Create(humano);
			seresVivos.Create(perro);
			
			
			Microbio colera= new Microbio();
			colera.NombreCientifico="Vibrio cholerae";
			colera.LapsoDeVidaEnAnios=2;
			colera.AnioDeDescubrimiento=1650;
			colera.ResponsableDe="Colera";
			
			Microbio malaria= new Microbio();
			malaria.NombreCientifico="Plasmodium";
			malaria.LapsoDeVidaEnAnios=1;
			malaria.AnioDeDescubrimiento=1850;
			malaria.ResponsableDe="Malaria";
			
			
			microbios= new DAO_Microbio();
			microbios.Create(colera);
			microbios.Create(malaria);
			
			
			List<SerVivo>listadoDeSeresVivos= seresVivos.Read();
			List<Microbio>listadoDeMicrobios=microbios.Read();
			
			SerVivo sv=listadoDeSeresVivos.Find(x=>x.NombreCientifico=="Homo Sapiens");
			
			cboSeresVivos.DataSource=listadoDeSeresVivos;
			//cboSeresVivos.DropDownStyle=ComboBoxStyle.DropDownList;
			cboMicrobios.DataSource=listadoDeMicrobios;
			cboMicrobios.DropDownStyle=ComboBoxStyle.DropDownList;
			
			cboSeresVivos.DisplayMember="nombreCientifico";
			cboSeresVivos.ValueMember="nombreCientifico";
			cboMicrobios.DisplayMember="nombreCientifico";
			cboMicrobios.ValueMember="nombreCientifico";
			

		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void BtnRegistrarSerVivoClick(object sender, EventArgs e)
		{
			SerVivo ser=new SerVivo();
			ser.NombreCientifico=txtSerVivoNombre.Text;
			ser.LapsoDeVidaEnAnios=Convert.ToInt32(txtLapsoDeVidaSerVivo.Text);
			
			seresVivos.Create(ser);
		
		
			cboSeresVivos.DataSource=null;
			cboSeresVivos.DataSource=seresVivos.Read();
			cboSeresVivos.DropDownStyle=ComboBoxStyle.DropDownList;	
			cboSeresVivos.DisplayMember="nombreCientifico";
			cboSeresVivos.ValueMember="nombreCientifico";
			
			txtSerVivoNombre.ResetText();
			txtLapsoDeVidaSerVivo.ResetText();
			
			
			MessageBox.Show("Ser vivo registrado!");
			
	
		}
		
		void BtnRegistrarMicrobioClick(object sender, EventArgs e)
		{
			Microbio mic=new Microbio();
			mic.NombreCientifico=txtNombreMicrobio.Text;
			mic.LapsoDeVidaEnAnios=Convert.ToInt32(txtLapsoDeVidaMicrobio.Text);
			mic.AnioDeDescubrimiento=Convert.ToInt32(txtAnioDescubrimiento.Text);
			mic.ResponsableDe=txtResponsableDe.Text;	
			microbios.Create(mic);
			
			
			cboMicrobios.DataSource=null;
			cboMicrobios.DataSource=microbios.Read();
			cboMicrobios.DropDownStyle=ComboBoxStyle.DropDown;
			cboMicrobios.DisplayMember="nombreCientifico";
			cboMicrobios.ValueMember="nombreCientifico";
			
			
			txtNombreMicrobio.ResetText();
			txtLapsoDeVidaMicrobio.ResetText();
			txtAnioDescubrimiento.ResetText();
			txtResponsableDe.ResetText();
			MessageBox.Show("Microbio registrado!");
	
		}
		void CboSeresVivosSelectedIndexChanged(object sender, EventArgs e)
		{
			
			SerVivo s= (SerVivo)cboSeresVivos.SelectedItem;
			txtSerVivoNombre.Text=s.NombreCientifico;
			txtLapsoDeVidaSerVivo.Text=Convert.ToString(s.LapsoDeVidaEnAnios);
		}
		void CboMicrobiosSelectedIndexChanged(object sender, EventArgs e)
		{
			Microbio mic=(Microbio)cboMicrobios.SelectedItem;
			txtNombreMicrobio.Text=mic.NombreCientifico;
			txtLapsoDeVidaMicrobio.Text=Convert.ToString(mic.LapsoDeVidaEnAnios);
			txtAnioDescubrimiento.Text=Convert.ToString(mic.AnioDeDescubrimiento);
			txtResponsableDe.Text=mic.ResponsableDe;
			

	
		}
		void BtnBorrarSerVivoClick(object sender, EventArgs e)
		{
			SerVivo ser=(SerVivo)cboSeresVivos.SelectedItem;
			String nombreCientificoDeSerVivo=ser.NombreCientifico;
			seresVivos.Delete(nombreCientificoDeSerVivo);
	
			cboSeresVivos.DataSource=null;
			cboSeresVivos.DataSource=seresVivos.Read();
			cboSeresVivos.DropDownStyle=ComboBoxStyle.DropDownList;
			cboSeresVivos.DisplayMember="nombreCientifico";
			cboSeresVivos.ValueMember="nombreCientifico";
			
			txtSerVivoNombre.ResetText();
			txtLapsoDeVidaSerVivo.ResetText();
			
			
			MessageBox.Show("Borrado exitoso!");
			
			
			
		}
		void BtnBorrarMicrobioClick(object sender, EventArgs e)
		{
			Microbio mic=(Microbio)cboMicrobios.SelectedItem;
			String nombreCientificoMicrobio=mic.NombreCientifico;
			microbios.Delete(nombreCientificoMicrobio);
	
			cboMicrobios.DataSource=null;
			cboMicrobios.DataSource=microbios.Read();
			cboMicrobios.DropDownStyle=ComboBoxStyle.DropDownList;
			cboMicrobios.DisplayMember="nombreCientifico";
			cboMicrobios.ValueMember="nombreCientifico";
			
			txtNombreMicrobio.ResetText();
			txtLapsoDeVidaMicrobio.ResetText();
			txtAnioDescubrimiento.ResetText();
			txtResponsableDe.ResetText();
			
			
			MessageBox.Show("Borrado exitoso!");
			
	
		}
		void BtnActualizarSerVivoClick(object sender, EventArgs e)
		{
			SerVivo ser=new SerVivo();
			ser.NombreCientifico=txtSerVivoNombre.Text;
			ser.LapsoDeVidaEnAnios=Convert.ToInt32(txtLapsoDeVidaSerVivo.Text);
			
			seresVivos.Update(ser);
		
		
			cboSeresVivos.DataSource=null;
			cboSeresVivos.DataSource=seresVivos.Read();
			cboSeresVivos.DropDownStyle=ComboBoxStyle.DropDownList;	
			cboSeresVivos.DisplayMember="nombreCientifico";
			cboSeresVivos.ValueMember="nombreCientifico";
			
			txtSerVivoNombre.ResetText();
			txtLapsoDeVidaSerVivo.ResetText();
			
			
			MessageBox.Show("Ser vivo actualizado!");
	
		}
		void BtnActualizarMicrobioClick(object sender, EventArgs e)
		{
			Microbio mic=new Microbio();
			mic.NombreCientifico=txtNombreMicrobio.Text;
			mic.LapsoDeVidaEnAnios=Convert.ToInt32(txtLapsoDeVidaMicrobio.Text);
			mic.AnioDeDescubrimiento=Convert.ToInt32(txtAnioDescubrimiento.Text);
			mic.ResponsableDe=txtResponsableDe.Text;	
			microbios.Update(mic);
			
			
			cboMicrobios.DataSource=null;
			cboMicrobios.DataSource=microbios.Read();
			cboMicrobios.DropDownStyle=ComboBoxStyle.DropDown;
			cboMicrobios.DisplayMember="nombreCientifico";
			cboMicrobios.ValueMember="nombreCientifico";
			
			
			txtNombreMicrobio.ResetText();
			txtLapsoDeVidaMicrobio.ResetText();
			txtAnioDescubrimiento.ResetText();
			txtResponsableDe.ResetText();
			cboSeresVivos.SelectedIndex=0;
			
			MessageBox.Show("Microbio actualizado!");
		}
		
		
		
		
		
	}
}
