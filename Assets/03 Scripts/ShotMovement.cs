using UnityEngine;
using System.Collections;

public class ShotMovement : MonoBehaviour {

    public GameObject markerPrefab;
    GameObject mark;

    Vector2 objectivePosition;
    Vector2 direction;
    public float speed = 3f;
    float angle;

    public enum shootType { forward, target };
    public shootType type = shootType.forward;

    public float maxRange = 4f;
    float currentRange;

    GameObject objectiveSprite;

    // Use this for initialization
    void Start () {
        objectivePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (type == shootType.target)
        {
            mark = Instantiate(markerPrefab) as GameObject;
            mark.transform.position = objectivePosition;
        }
        else {
            direction = (objectivePosition - (Vector2)transform.position).normalized;
            angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            currentRange = 0f;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (type == shootType.target)
        {
            transform.position = Vector2.MoveTowards(transform.position, objectivePosition, speed * Time.deltaTime);
            if ((Vector2)transform.position == objectivePosition)
            {
                shootDie();
            }
        }
        else {

            transform.position += new Vector3(direction.x * Time.deltaTime * speed, direction.y * Time.deltaTime * speed, 0);
            currentRange += Time.deltaTime * speed;

            if (currentRange > maxRange)
            {
                shootDie();
            }
        }
        
        
    }
    public void shootDie() {
        //animations
        if (type == shootType.target) {
            Destroy(mark);
        }
        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("noticed: " + other.name);
        if (other.tag == "Enemy")
        {
            other.GetComponent<RedBlink>().startBlink();
        }
        else if (other.tag == "enemyAttack") {
            other.GetComponent<ShotMovement>().shootDie();
        }

        if (other.tag != "PJ" && other.tag != "friendlyAttack")
        {
            shootDie();
        }
    }
}
