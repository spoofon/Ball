using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool TryJump;
    bool Start_Falling;
    float Jump_Boost = 6;
    
    bool Falling = true;
    public BlocksLeft The_Text;
    bool Can_Go_Left = true, Can_Go_Right = true;
    public Camera The_Camera;

    float Player_Size = .3f;

    float How_High_Can_Jump = 0;
    bool Jump, Can_Jump = true;
    public Rigidbody2D RB;

    public FixedJoystick Joy_Stick;

    Vector2 Movement;

    float XSpeed = 9, YSpeed = 1;

    public PlayerFloor Detection_Script;

    public PlayerRoof Roof_Detection_Script;

    

    public Animator An;
    
   

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

      

    }




     private void GameOver(){

        
        GameManager.Instance.GameOver();



     }

     
    // Update is called once per frame
    void Update()
    {
        GetInput();


        // The_Camera.transform.position=new Vector3(transform.position.x,transform.position.y,-2);


        if (Input.GetKey("space"))
        {
            DoTheJump();

            // Blocks_Gone.UpdateTheBlocks();
        }

         if (Falling){TryJump=false;}

         if(TryJump){

           DoTheJump();

         }

        
      //  print("fallimg speed " + How_High_Can_Jump);

    }


    private void FixedUpdate()
    {


        if (Jump) { Jumping(); }
        
        JumpStuff();


        if (Falling) { FallingDown(); }


        Move();


    }


    private void GetInput()
    {

        Movement = new Vector2(Joy_Stick.Horizontal, 0);

        ///////////////Which way to face////////////////

        An.SetFloat("speed", Joy_Stick.Horizontal);
        //////////////////////////////////////////////////////////////



        ////////////////////left right//////////////////////////////////////////////////
        if (!Can_Go_Left && Joy_Stick.Horizontal < 0) { Movement.x = 0; }

        if (!Can_Go_Right && Joy_Stick.Horizontal > 0) { Movement.x = 0; }


    }


    private void Move()
    {


        RB.velocity = new Vector2(Movement.x * XSpeed, Movement.y * YSpeed);



    }



    private void JumpStuff()
    {

        ///////////////Jump Stuff
        if (Detection_Script.OnTheGround()) { Can_Jump = true;  Falling = false; How_High_Can_Jump = -1;}


        if (!Detection_Script.OnTheGround()) {  Can_Jump = false; Falling = true; }

         
       
        /////////////////////////////////////////////////////////////////////////////



        if (Roof_Detection_Script.ImOnTheRoof) { Falling = true; Jump = false; How_High_Can_Jump = -3-Jump_Boost;TryJump=false; print("im on the roof"); }


     

    }


    private void FallingDown()
    {

        


        Movement.y = How_High_Can_Jump;

        How_High_Can_Jump = How_High_Can_Jump - 9f * Time.deltaTime;

        if (How_High_Can_Jump <= -8) { How_High_Can_Jump = -8; }

    }

    private void Jumping()
    {


        Movement.y = How_High_Can_Jump;

        How_High_Can_Jump = How_High_Can_Jump - 5f * Time.deltaTime;

        if (How_High_Can_Jump <= 0) { Jump = false; How_High_Can_Jump = -1; }



    }

    


    public void CheckForJump()
    {


      TryJump=true;
       




    }

    private void DoTheJump(){


       if (Can_Jump) { Jump = true; How_High_Can_Jump = Jump_Boost;}


    }



    public void StopLeft(bool can_go_left)
    {


        Can_Go_Left = can_go_left;


    }


    public void StopRight(bool can_go_right)
    {


        Can_Go_Right = can_go_right;


    }






    public void IncreaseSize()
    {

        Player_Size = Player_Size + .04f;

        Jump_Boost = Jump_Boost + 1f;

       // XSpeed = XSpeed + 1;

        transform.localScale = new Vector3(Player_Size, Player_Size, 0);

        print("at size");

    }


    public void DecreaseSize(){

          Player_Size = Player_Size - .05f;

       // Jump_Boost = Jump_Boost - .8f;

       // XSpeed = XSpeed + 1;

        transform.localScale = new Vector3(Player_Size, Player_Size, 0);

        print("Decrease Size");



    }

}
