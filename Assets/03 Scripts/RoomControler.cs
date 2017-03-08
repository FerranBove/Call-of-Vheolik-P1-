using UnityEngine;
using System.Collections;

public class RoomControler : MonoBehaviour {
    public GameObject GroundPrefab;
    public GameObject WallPrefab;
    public int x;
    public int y;
    public float midaX = 3;
    public float midaY = 4;

    // Use this for initialization
    void Start () {

        buildGround();
        buildWalls();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void buildGround() {
        GameObject actual;
        for (int i = 0; i < x; i++) //generates floor with x-y size
        {
            for (int j = 0; j < y; j++)
            {
                actual = Instantiate(GroundPrefab);
                actual.transform.position = new Vector3(i * midaX, j * midaY, 0);
            }
        }
    }

    void buildWalls() {
        GameObject actual;
        //Top & Down
        for (int i = 0; i < x; i++)
        {
            actual = Instantiate(WallPrefab);
            actual.transform.position = new Vector3(i * midaX, (y)*midaY, 0);

            actual = Instantiate(WallPrefab);
            actual.transform.position = new Vector3(i * midaX, (-1) * midaY, 0);
        }
        //Left & Right
        for (int j = 0; j < y; j++)
        {
            actual = Instantiate(WallPrefab);
            actual.transform.position = new Vector3(x * midaX, j * midaY, 0);

            actual = Instantiate(WallPrefab);
            actual.transform.position = new Vector3((-1) * midaX, j * midaY, 0);
        }
    }
}
