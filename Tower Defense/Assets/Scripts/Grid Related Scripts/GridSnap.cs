using UnityEngine;
using System.Collections;

public class GridSnap : MonoBehaviour {

	private Transform currentPos;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () 
	{
		
		currentPos = this.gameObject.transform;
		if (Input.GetMouseButtonUp (0))
		{
			float newX = Mathf.Round (currentPos.position.x);
			float newZ = Mathf.Round (currentPos.position.z);
			currentPos.position = new Vector3(newX, 1f, newZ);

		}
	
	}
}
