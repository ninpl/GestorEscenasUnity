//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// SProteo.cs (15/03/2017)														\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:		Sistema que gestiona el cambio de escenas.					\\
// Fecha Mod:		15/03/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
#endregion

namespace MoonPincho
{
	/// <summary>
	/// <para>Sistema que gestiona el cambio de escenas</para>
	/// </summary>
	[AddComponentMenu("Moon Pincho/Sistemas/SProteo")]
	public class SProteo : MonoBehaviour 
	{
		#region Variables Publicas
		/// <summary>
		/// <para>NGUI progress bar para la carga.</para>
		/// </summary>
		public UISlider progressBar;                                            // NGUI progress bar para la carga
		#endregion

		#region API
		/// <summary>
		/// <para>Carga la escena dada en modo Additive.</para>
		/// </summary>
		/// <param name="nombre">Nombre de la escena.</param>
		public void LoadScene(string nombre)// Carga la escena dada en modo Additive
		{
			SceneManager.LoadScene(nombre, LoadSceneMode.Additive);
		}

		/// <summary>
		/// <para>Descarga la escena dada.</para>
		/// </summary>
		/// <param name="nombre">Nombre de la escena.</param>
		public void UnLoadScene(string nombre)// Descarga la escena dada
		{
			SceneManager.UnloadSceneAsync(nombre);
		}

		/// <summary>
		/// <para>Carga la escena dada asyncronamente.</para>
		/// </summary>
		/// <param name="nombre">Nombre de la escena.</param>
		public void LoadSceneAsyc(string nombre)// Carga la escena dada asyncronamente.
		{
			StartCoroutine(UpdateProgress(nombre));
		}

		/// <summary>
		/// <para>Descarga la escena actual.</para>
		/// </summary>
		public void UnLoadActual()// Descarga la escena actual.
		{
			SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
		}
		#endregion

		#region Funcionalidad
		/// <summary>
		/// <para>Actualiza el progress bar mientras carga la escena Asyncronamente.</para>
		/// </summary>
		/// <param name="nombre">Nombre de la escena.</param>
		/// <returns>Null</returns>
		public IEnumerator UpdateProgress(string nombre)// Actualiza el progress bar mientras carga la escena Asyncronamente
		{
			AsyncOperation cargando = SceneManager.LoadSceneAsync(nombre);

			while (!cargando.isDone)
			{
				this.progressBar.value = cargando.progress;
				Debug.Log(cargando.progress);
				yield return null;
			}
		}
		#endregion
	}
}
