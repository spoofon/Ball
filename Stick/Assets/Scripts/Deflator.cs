using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deflator : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

     
     if (other.transform.tag == "Player")
        {
             transform.position= new Vector3(100,200,0);
        }
    
     

    }
}
