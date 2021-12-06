using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTanque : MonoBehaviour
{
    public float vel;
    public float velRot;
    float nextFire;
    float fireRate;
    public Rigidbody myRigid;
    public GameObject ammoOriginal;
    public GameObject timer; 


    //point of shoot
    public GameObject refSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTank();
        Shoot(); 
    }

    void MoveTank()
    {
        //Rotate Y right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, velRot * Time.deltaTime, 0, Space.Self);
        }
        //Rotate Y left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, -velRot * Time.deltaTime, 0, Space.Self);
        }


        //Move forward
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0, 0, vel * Time.deltaTime, Space.Self);
        }
        //Move backwards
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, 0, -vel * Time.deltaTime, Space.Self);
        }
    }

    void Shoot()
    {
        //create clon of the ammo
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            fireRate = 1;
            nextFire = Time.time + fireRate;

            //Get the ref of the new clon
            GameObject newAmmo;
            newAmmo = (GameObject)Instantiate(ammoOriginal, refSpawn.transform.position, this.transform.rotation);
            Destroy(newAmmo, 2);

            //Get the ref of Rigidbody
            Rigidbody clonRigid;
            clonRigid = newAmmo.GetComponent<Rigidbody>();

            //Velocity
            clonRigid.velocity = refSpawn.transform.forward * Time.deltaTime * 75000;

        }
    }


}
