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
using UnityEditor.SceneManagement;
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
			EditorSceneManager.OpenScene("Assets/Gestor Escenas/Scenes/main.unity",OpenSceneMode.Single);
		}

		[MenuItem("Moon Pincho/Scenes/Scene 1", false, 2)]
		public static void InitScene1()
		{
			EditorSceneManager.OpenScene("Assets/Gestor Escenas/Scenes/scene1.unity", OpenSceneMode.Single);
		}

		[MenuItem("Moon Pincho/Scenes/Scene 2", false, 3)]
		public static void InitScene2()
		{
			EditorSceneManager.OpenScene("Assets/Gestor Escenas/Scenes/scene2.unity", OpenSceneMode.Single);
		}

		[MenuItem("Moon Pincho/Scenes/Scene 3", false, 4)]
		public static void InitScene3()
		{
			EditorSceneManager.OpenScene("Assets/Gestor Escenas/Scenes/scene3.unity", OpenSceneMode.Single);
		}
		#endregion
	}
}
