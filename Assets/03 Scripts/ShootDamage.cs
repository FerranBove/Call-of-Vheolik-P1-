using UnityEngine;
using System.Collections;

public class ShootDamage : MonoBehaviour {

    public float damage = 10f;

    public bool haveTimeDamage = false;
    public float dTime;
    public float dmg2;
    public int tickNum;

    public bool haveCreep = false;
    public GameObject creep;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void doDamage(GameObject other) {
        other.GetComponent<EnemyController>().getDamage(damage);
        if (haveTimeDamage)
        {
            other.GetComponent<RedBlink>().timeDamage(dTime, dmg2, tickNum);
        }
        if (haveCreep) {
            //instanciar creep
            //posar creep fora del pare perk no es destrossi
        }
    }
}
