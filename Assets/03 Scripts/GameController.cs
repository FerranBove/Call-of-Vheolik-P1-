using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Texture2D cursor;
    public CharacterShooter chShooter;

    public Scrollbar coolDBasic;
    public Scrollbar coolD1;
    public Scrollbar coolD2;
    public Scrollbar coolD3;
    public Scrollbar coolD4;

    // Use this for initialization
    void Start () {
        Cursor.SetCursor(cursor,Vector2.zero, CursorMode.Auto);
	}
	
	// Update is called once per frame
	void Update () {
        coolDBasic.size = chShooter.bCooldown / chShooter.basicCooldown;
        coolD1.size = chShooter.cDown1 / chShooter.cooldown1;
        coolD2.size = chShooter.cDown2 / chShooter.cooldown2;
        coolD3.size = chShooter.cDown3 / chShooter.cooldown3;
        coolD4.size = chShooter.cDown4 / chShooter.cooldown4;

    }

}
