using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour {
	private GridShow gridShow;
	// Update is called once per frame
	public bool buttonPress = false;
	public void ButtonPress()
	{
				buttonPress = true;
	}
		
}