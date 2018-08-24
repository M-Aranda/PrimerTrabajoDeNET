/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 8/23/2018
 * Time: 7:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Prueba_1_Marcelo_Aranda.Model
{
	/// <summary>
	/// Description of SerVivo.
	/// </summary>
	public class SerVivo
	{
		
					
			 public String nombreCientifico;
			 public int lapsoDeVidaEnAnios;
			
						
		public SerVivo()
		{
			
			
		}

			public string  NombreCientifico {
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

		
		
		
	}
}
