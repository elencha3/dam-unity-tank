using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CuentaAtras : MonoBehaviour
{
    public Text text;
    public float time;
    string message = "Te has quedado sin gasolina";
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            text.text = "" + time.ToString("f0");
            Debug.Log(time.ToString("f0"));

        } else {
            this.GetComponent<ControlTanque>().enabled = false;
            text.text = message;
            Debug.LogWarning(message); 
        }
    }
}
