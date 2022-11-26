using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMan : MonoBehaviour
{
    int One_Time;
    public CharacterController2D Controller;

    private FixedJoystick Joy_Stick;

    private float Speed=40F;

    private float Left_Or_Right_Joy;

    public bool Jump;

     float Player_Size = .3f;

    public Animator Am;

    bool On_The_Ground;

    // Start is called before the first frame update
    void Start()
    {
        Joy_Stick = FindObjectOfType<FixedJoystick>();

       
    }

    // Update is called once per frame
    void Update()
    {
        
    Left_Or_Right_Joy=Joy_Stick.Horizontal*Speed;

        Am.SetFloat("Speed",Mathf.Abs(Left_Or_Right_Joy));

   

   if (Input.GetKey("space"))
        {
        
        Jump=true;

        }

    
       
     Am.SetBool("Jump", Jump);

    

    }


  

    void FixedUpdate(){


     Controller.Move(Left_Or_Right_Joy*Time.fixedDeltaTime,false,Jump);

        Jump = false;

     
 

     }


    public void DoTheJump() {


        Jump = true;

       

    }


    public void OnLanding() {



      
       // Am.SetBool("Jump", false);

        

    }


public void IncreaseSize()
    {



       // Controller.m_JumpForce = 1000;

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
