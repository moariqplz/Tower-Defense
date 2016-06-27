using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour {
	private GridShow gridShow;
	// Update is called once per frame
	public bool buttonPress = false;
	void Start()
	{
		GameObject gridObject = GameObject.Find ("GridBlock(Clone)");
		if (gridObject != null)
		{
			Debug.Log ("Script Found");
			gridShow = gridObject.GetComponent<GridShow> ();
		}
		if (gridObject == null)
		{
			Debug.Log ("Cannot find Grid Script");
		}
	}
	void Update()
	{
		//for(int i = 0; i < Input.touchCount; i++)
		//{
		if (Input.GetMouseButtonDown (0))
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray))
			{
				gridShow.isActive = true;
			}

		}
		//}

	}
}