using UnityEngine;
using System.Collections;
//-----------------------------------------------------------------------------------
// This class handle the change of levels/ Scenes
public class LevelManager : MonoBehaviour {
	//-----------------------------------------------------------------------------------
	//Load a Level based of the name
	public void LoadLevel(string name)
	{
		Debug.Log ("Load this level: " + name);
		Application.LoadLevel(name);
	}
	//-----------------------------------------------------------------------------------
	//Deal with the Exit of the app
	public void QuitRequest()
	{
		Debug.Log ("Quit Game Requested");
		Application.Quit ();
	}
}
