using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hareket : MonoBehaviour
{
    public Vector3 hareket;

    public GameObject text1;
    public GameObject text2;

    public float guc;

    private bool yerde;
    
    void Start()
    {
        yerde = true;
    }

    void Update()
    {
        Getinput();

        text1.GetComponent<Text>().text = "" + hareket.x;
        text2.GetComponent<Text>().text = "" + hareket.z;
        Input.GetKeyDown(KeyCode.Space);
        if (Input.GetKeyDown(KeyCode.Space) && yerde == true)
        {
            yerde = false;
            hareket += new Vector3(0, guc, 0);
        }
        GetComponent<Rigidbody>().AddForce(hareket);
    }
    private void Getinput()
    {
        hareket = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Yer")
        {
            yerde = true;
        }
    }
}
