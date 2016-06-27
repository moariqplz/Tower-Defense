using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour {
	public Color invalidSpotColor;
	public Color validSpotColor;
	public Transform topRightCorner;
	public Transform lowerLeftCorner;
	//public GameObject towerPrefab;
	private Transform currentPos;
	private Vector3 newPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetMouseButtonDown (0))
		{
			//Plane turretPlane = new Plane (Vector2.up, towerTransform.position);
			Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (myRay, out hit))
			{
				newPos = hit.point;
				currentPos.transform.position = newPos;
			//Instantiate (towerPrefab, towerPrefab.transform.position, towerPrefab.transform.rotation);
			Renderer r = this.GetComponent<Renderer> (); 
			//currentPos.position = new Vector3 (Input.mousePosition.x, 1f, Input.mousePosition.);
			if (currentPos.position.x < lowerLeftCorner.position.x
				|| currentPos.position.x > topRightCorner.position.x)
			{
				r.material.SetColor ("_Color", invalidSpotColor);	
				//Destroy (this.gameObject);
			}
			if (currentPos.position.z < lowerLeftCorner.position.z
				|| currentPos.position.z > topRightCorner.position.z)
			{
				r.material.SetColor ("_Color", invalidSpotColor);	
				//Destroy (this.gameObject);
			}
			r.material.SetColor ("_Color", validSpotColor);	
			Debug.Log (Input.mousePosition.ToString ());
			Debug.Log ("Current Pos" + currentPos.position.ToString ());
			}
		}
	}

}
