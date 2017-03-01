using UnityEngine;
using System.Collections;

public class CharacterShooter : MonoBehaviour {

    //Basic attack ------------------------
    public GameObject basicAttack;
    public float basicCooldown = 0.5f;
    [HideInInspector]
    public float bCooldown = 0;

    //Attack 1 ----------------------------
    public GameObject attack1;
    public float cooldown1 = 0.5f;
    [HideInInspector]
    public float cDown1 = 0;

    //Attack 2 ----------------------------
    public GameObject attack2;
    public float cooldown2 = 0.5f;
    [HideInInspector]
    public float cDown2 = 0;

    //Attack 3 ----------------------------
    public GameObject attack3;
    public float cooldown3 = 0.5f;
    [HideInInspector]
    public float cDown3 = 0;

    //Attack 4 ----------------------------
    public GameObject attack4;
    public float cooldown4 = 0.5f;
    [HideInInspector]
    public float cDown4 = 0;

    //Others ------------------------------
    public int handPosX = 0;
    public int handPosY = 0;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        decressCooldowns();

        if (Input.GetMouseButton(0) && bCooldown <= 0f) {
            shootBasic();
            bCooldown = basicCooldown;
        }
        else if (Input.GetKeyDown("1") && cDown1 <= 0f)
        {
            shootAttack1();
            cDown1 = cooldown1;
        }
        else if (Input.GetKeyDown("2") && cDown2 <= 0f) {
            shootAttack2();
            cDown2 = cooldown2;
        }
        else if (Input.GetKeyDown("3") && cDown3 <= 0f)
        {
            shootAttack3();
            cDown3 = cooldown3;
        }
        else if (Input.GetKeyDown("4") && cDown4 <= 0f)
        {
            shootAttack4();
            cDown4 = cooldown4;
        }
    }

    void shootBasic()
    {
        GameObject shoot = Instantiate(basicAttack) as GameObject;
        shoot.transform.position = new Vector3(transform.position.x + handPosX, transform.position.y + handPosY, 0);
    }
    void shootAttack1() {
        GameObject shoot = Instantiate(attack1) as GameObject;
        shoot.transform.position = new Vector3(transform.position.x+handPosX, transform.position.y + handPosY, 0);
    }
    void shootAttack2()
    {
        GameObject shoot = Instantiate(attack2) as GameObject;
        shoot.transform.position = new Vector3(transform.position.x + handPosX, transform.position.y + handPosY, 0);
    }
    void shootAttack3()
    {
        GameObject shoot = Instantiate(attack3) as GameObject;
        shoot.transform.position = new Vector3(transform.position.x + handPosX, transform.position.y + handPosY, 0);
    }
    void shootAttack4()
    {
        GameObject shoot = Instantiate(attack4) as GameObject;
        shoot.transform.position = new Vector3(transform.position.x + handPosX, transform.position.y + handPosY, 0);
    }

    void decressCooldowns() {
        if (bCooldown > 0f)
            bCooldown -= Time.deltaTime;

        if (cDown1 > 0f)
            cDown1 -= Time.deltaTime;

        if (cDown2 > 0f)
            cDown2 -= Time.deltaTime;

        if (cDown3 > 0f)
            cDown3 -= Time.deltaTime;

        if (cDown4 > 0f)
            cDown4 -= Time.deltaTime;
    }
}
