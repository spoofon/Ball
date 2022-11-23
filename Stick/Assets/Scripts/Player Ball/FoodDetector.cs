using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDetector : MonoBehaviour
{
    
    public StickMan The_Player_Script;
    
   private void OnTriggerEnter2D(Collider2D other)
    {

     


    if (other.transform.tag == "food")
        {

     
     The_Player_Script.IncreaseSize();

     print("got Food!!!!");

    }

if (other.transform.tag == "thining")
        {

     
     The_Player_Script.DecreaseSize();

     print("Got Deflator");

    }







    }







}
