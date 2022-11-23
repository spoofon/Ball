using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFloor : MonoBehaviour
{

    public bool ImOnTheGround;

    public Player The_Player_Script;
    
   private void OnTriggerEnter2D(Collider2D other)
    {

     

 if (other.transform.tag == "ground" || other.transform.tag == "brick")
        {

     ImOnTheGround=true;

      print("im on the ground");
     

    }

 




    }



private void OnTriggerExit2D(Collider2D other)
    {

     if (other.transform.tag == "ground" || other.transform.tag == "brick")
        {

       ImOnTheGround=false;


       print("in the air");

        }
    }




public bool OnTheGround(){


return ImOnTheGround;

}




}
