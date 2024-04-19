using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        
    }

    private void OnMouseDown()
    {
        rbody.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
    }

    public void Test ()
    {
        Debug.Log("Hallo!");
    }
    
 
}