/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 8/23/2018
 * Time: 8:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Prueba_1_Marcelo_Aranda.Model;
using System.Collections.Generic;
using System.Linq;

namespace Prueba_1_Marcelo_Aranda.DAO
{
	/// <summary>
	/// Description of DAO_SerVivo.
	/// </summary>
	public class DAO_SerVivo : IDAO<SerVivo>
	{
		List<SerVivo> lista;
		
		public DAO_SerVivo()
		{
			this.lista=new List<SerVivo>();
		}
	
	
		public void Create(SerVivo obj)
		{
			lista.Add(obj);
		}
		public List<SerVivo> Read()
		{
			return lista;
		}
		public void Update(SerVivo ser)
		{
			
		var obj = lista.FirstOrDefault(x => x.NombreCientifico == ser.NombreCientifico);
		obj.LapsoDeVidaEnAnios=ser.LapsoDeVidaEnAnios;
			
			
		}
		public void Delete(String nombre)
		{
			lista.RemoveAll(s => s.NombreCientifico == nombre);
		}
	
	}
}
