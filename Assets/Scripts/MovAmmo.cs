using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovAmmo : MonoBehaviour
{
    public float vel;

    void Update()
    {
        this.transform.Translate(0, 0, vel * Time.deltaTime);
        
    }
}
