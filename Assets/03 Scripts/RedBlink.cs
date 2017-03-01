using UnityEngine;
using System.Collections;

public class RedBlink : MonoBehaviour {

    public float time = 1.0f;
    public bool multiple=false;
    float timer;

    public bool blinking;
    bool isRed;

	// Use this for initialization
	void Start () {
        timer = 0.0f;
        isRed = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (blinking) {
            timer += Time.deltaTime;
            if (timer > time) {
                changeColor();
                timer = 0f;
            }
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
}
