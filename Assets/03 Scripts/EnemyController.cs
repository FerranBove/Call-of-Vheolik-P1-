using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float life;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (life <= 0.1f)
        {
            life = 0f;
            die();
        }
    }

    public void getDamage(float dmg) {
        Debug.Log("Got " + dmg + " damage");
        life -= dmg;
    }
    void die() {
        Debug.Log("Enemy die");
        Destroy(this.gameObject);
    }
}
