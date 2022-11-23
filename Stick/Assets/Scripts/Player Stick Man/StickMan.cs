using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMan : MonoBehaviour
{
    
    public CharacterController2D Controller;

    private FixedJoystick Joy_Stick;

    private float Speed=40F;

    private float Left_Or_Right_Joy;

    public bool Jump;

     float Player_Size = .3f;

    // Start is called before the first frame update
    void Start()
    {
        Joy_Stick = FindObjectOfType<FixedJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        
    Left_Or_Right_Joy=Joy_Stick.Horizontal*Speed;

    //Left_Or_Right_Joy=Input.GetAxisRaw("Horizontal")*Speed;

   if (Input.GetKey("space"))
        {
        
        Jump=true;

        }



    }


     void FixedUpdate(){


     Controller.Move(Left_Or_Right_Joy*Time.fixedDeltaTime,false,Jump);

     Jump=false;
 

     }



public void IncreaseSize()
    {

        Player_Size = Player_Size + .04f;

        transform.localScale = new Vector3(Player_Size, Player_Size, 0);

     if(!Controller.m_FacingRight){


          Vector3 theScale = transform.localScale;
		   theScale.x *= -1;
		   transform.localScale = theScale;




        }
        

    }

public void DecreaseSize(){

          Player_Size = Player_Size - .04f;

      
        transform.localScale = new Vector3(Player_Size, Player_Size, 0);

        if(!Controller.m_FacingRight){


          Vector3 theScale = transform.localScale;
		   theScale.x *= -1;
		   transform.localScale = theScale;




        }

       

        



    }



}
