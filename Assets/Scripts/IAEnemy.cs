using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour
{
    //Tank reference
    public GameObject refTank;
    
    //Velocity 
    public float vel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Look for direction
        Vector3 distTank = refTank.transform.position - this.transform.position;
        
        //To chase the tank
        this.transform.Translate(vel * distTank.normalized * Time.deltaTime);
        

        if (refTank.GetComponent<ControlTanque>().enabled == false)
        {
            this.GetComponent<IAEnemy>().enabled = false;
        }
    }
}
