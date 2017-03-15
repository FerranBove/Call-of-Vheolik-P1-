using UnityEngine;
using System.Collections;

public class RedBlink : MonoBehaviour {

    public float time = 1.0f;
    public bool multiple=false;
    float timer;

    public bool blinking;
    bool isRed;

    bool activeTimeDamage;
    float damageTime;
    float damageTimer;
    float tickDamage;
    int tickAmount;

    // Use this for initialization
    void Start () {
        timer = 0.0f;
        isRed = false;
        activeTimeDamage = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (blinking)
        {
            timer += Time.deltaTime;
            if (timer > time)
            {
                changeColor();
                timer = 0f;
            }
        }
        else {
            timer = 0;
        }

        if (activeTimeDamage)
        {
            damageTimer += Time.deltaTime;
            if (damageTimer > damageTime / tickAmount) {
                if (this.tag == "Enemy") {
                    this.GetComponent<EnemyController>().getDamage(tickDamage);
                }
                tickAmount--;
                if (tickAmount <= 0)
                {
                    activeTimeDamage = false;
                }
            }
        }
        else {
            damageTimer = 0f;
        }
	}

    public void startBlink() {
        blinking = true;
        timer = 0.0f;

        changeColor();
    }
    void changeColor() {
        if (isRed)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            isRed = false;
            if (!multiple) {
                blinking = false;
            }
        }
        else if (blinking){
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            isRed = true;
        }
        
    }
    public void timeDamage(float dTime, float dmg, int tickNum) {
        tickDamage = dmg / tickNum;
        tickAmount = tickNum;
        damageTime = dTime;
        activeTimeDamage = true;
    }
}
