/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 8/23/2018
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Prueba_1_Marcelo_Aranda.Model
{
	/// <summary>
	/// Description of Microbio.
	/// </summary>
	public class Microbio : SerVivo
	{
		
		int anioDeDescubrimiento;
		String responsableDe;
		
				
		public Microbio()
		{
		}

		public string NombreCientifico {
			get {
				return nombreCientifico;
			}
			set {
				nombreCientifico = value;
			}
		}

		public int LapsoDeVidaEnAnios {
			get {
				return lapsoDeVidaEnAnios;
			}
			set {
				lapsoDeVidaEnAnios = value;
			}
		}

		public int AnioDeDescubrimiento {
			get {
				return anioDeDescubrimiento;
			}
			set {
				anioDeDescubrimiento = value;
			}
		}

		public string ResponsableDe {
			get {
				return responsableDe;
			}
			set {
				responsableDe = value;
			}
		}

		
		
		
	}
}
