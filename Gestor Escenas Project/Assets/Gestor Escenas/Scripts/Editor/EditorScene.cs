//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// EditorScene.cs (18/03/2017)													\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:		Herramienta para cambiar de escena rapidamente.				\\
// Fecha Mod:		18/03/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
#endregion

namespace MoonPincho
{
	/// <summary>
	/// <para>Herramienta para cambiar de escena rapidamente</para>
	/// </summary>
	[AddComponentMenu("Moon Pincho/Editor/EditorScene")]
	public class EditorScene : MonoBehaviour 
	{
		#region Menus
		[MenuItem("Moon Pincho/Scenes/Main",false,1)]
		public static void InitSceneMain()
		{
			SceneManager.LoadScene("main");
		}
		#endregion
	}
}
