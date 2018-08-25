/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 8/24/2018
 * Time: 7:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Prueba_1_Marcelo_Aranda.DAO;
using System.Collections.Generic;
using System.Linq;

namespace Prueba_1_Marcelo_Aranda.Model
{
	/// <summary>
	/// Description of DAO_Microbio.
	/// </summary>
	public class DAO_Microbio : IDAO<Microbio>
	{
		List<Microbio> lista;
		
		public DAO_Microbio()
		{
			this.lista=new List<Microbio>();
		}


		public void Create(Microbio obj)
		{
			lista.Add(obj);
		}

		public System.Collections.Generic.List<Microbio> Read()
		{
			return lista;
		}

		public void Update(Microbio mic)
		{
		var obj = lista.FirstOrDefault(x => x.NombreCientifico == mic.NombreCientifico);
		mic=obj;
		}

		public void Delete(string nombre)
		{
			lista.RemoveAll(m => m.NombreCientifico == nombre);
		}

		
	}
}
