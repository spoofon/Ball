using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoof : MonoBehaviour
{
    // Start is called before the first frame update
   public bool ImOnTheRoof;

   public Player The_Player_Script;
    
   private void OnTriggerEnter2D(Collider2D other)
    {

     

 if (other.transform.tag == "ground")
        {

     ImOnTheRoof=true;


    // print("im on the Roof");


    }

    }

    



private void OnTriggerExit2D(Collider2D other)
    {
       ImOnTheRoof=false;
    }




public bool OnTheGround(){


return ImOnTheRoof;

}




}
