/*
 * Created by SharpDevelop.
 * User: Marce
 * Date: 8/23/2018
 * Time: 4:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic; //Necesario para usar listas

namespace Prueba_1_Marcelo_Aranda.DAO
{
	/// <summary>
	/// Description of IDAO.
	/// </summary>
	 interface IDAO<T>
	{
		
		void Create(T obj);
		List<T> Read();
		void Update(T obj);
		void Delete(String nombre);
		
	}
}
