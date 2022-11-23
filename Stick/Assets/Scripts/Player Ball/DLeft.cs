using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DLeft : MonoBehaviour
{
    
      public Player The_Player_Script;


    private void OnTriggerEnter2D(Collider2D other)
    {

     

 if (other.transform.tag == "ground")
        {

    



    The_Player_Script.StopLeft(false);

    }


}



 private void OnTriggerExit2D(Collider2D other)
    {

     

 if (other.transform.tag == "ground")
        {

    



    The_Player_Script.StopLeft(true);

    }


}



}
