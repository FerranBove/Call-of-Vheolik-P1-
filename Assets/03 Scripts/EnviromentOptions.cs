using UnityEngine;
using System.Collections;

public class EnviromentOptions : MonoBehaviour {

    public enum enviromentTypes { castell_g, casa_g, gespa_g, cami_g, castell_w, casa_w, forest_w, cabe_w };
    public enviromentTypes Type = enviromentTypes.gespa_g;
    SpriteRenderer sRenderer;
    public Sprite[] spriteArray;

	// Use this for initialization
	void Start () {
        sRenderer = this.GetComponent<SpriteRenderer>();
        sRenderer.sprite = spriteArray[(int)Type];
	}
	
}

