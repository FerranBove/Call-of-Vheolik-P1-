using UnityEngine;
using System.Collections;

public class GroundOptions : MonoBehaviour {
    public enum groundTypes { castell, casa, gespa, cami};
    public groundTypes Type= groundTypes.gespa;
    SpriteRenderer sRenderer;
    public Sprite[] spriteArray;
	// Use this for initialization
	void Start () {
        sRenderer = this.GetComponent<SpriteRenderer>();
        sRenderer.sprite = spriteArray[(int)Type];
	}
	
}

