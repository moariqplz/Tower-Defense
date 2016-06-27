using UnityEngine;
using System.Collections;

public class GridShow : MonoBehaviour {
	public bool isActive = false;
	private Button button;
	// Use this for initialization
	void Start () {
		GameObject buttonObject = GameObject.FindGameObjectWithTag ("Button");
		button = buttonObject.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update()
	{
		if (button.buttonPress == true)
		{
			gameObject.GetComponent<Renderer> ().enabled = true;
		}
		else
		{
			gameObject.GetComponent<Renderer> ().enabled = false;
		}
	}
}
