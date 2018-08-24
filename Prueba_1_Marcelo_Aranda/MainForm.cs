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

namespace Prueba_1_Marcelo_Aranda
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
			
			DAO_SerVivo seresVivos= new DAO_SerVivo();
			seresVivos.Create(humano);
			seresVivos.Create(perro);
			
			List<SerVivo>lis= seresVivos.Read();
			
			SerVivo sv=lis.Find(x=>x.NombreCientifico=="Homo Sapiens");
			txtNomCien.Text=Convert.ToString(sv.LapsoDeVidaEnAnios);
			
			

		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
