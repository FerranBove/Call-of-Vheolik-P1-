using UnityEngine;
using System.Collections;

public class RoomControler : MonoBehaviour {
    public GameObject GroundPrefab;
    public int x;
    public int y;
    public int midax = 50;

	// Use this for initialization
	void Start () {
        GameObject actual;
	for(int i=0; i<x; i++)
        {
            actual=Instantiate(GroundPrefab);
            actual.transform.position = new Vector3(i*midax,0,0); //afegir Y

        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
