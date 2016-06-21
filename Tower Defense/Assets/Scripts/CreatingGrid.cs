using UnityEngine;
using System.Collections;

public class CreatingGrid : MonoBehaviour {
	public GameObject CellPrefab;
	public Vector3 Size;
	// Use this for initialization
	void Start () 
	{
		CreateGrid ();	
	}
	void CreateGrid()
	{
		//Create the Grid Here
		for (int x = -6; x < Size.x - 5; x++)
		{
			for (int y = -5; y < Size.y - 4; y++)
			{
				GameObject CellBlock = (GameObject)Instantiate (CellPrefab, new Vector3 (x, y, 0), CellPrefab.transform.rotation);
				CellBlock.transform.parent = transform;
			}
		}
	}
}
