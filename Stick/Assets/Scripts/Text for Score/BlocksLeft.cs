using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BlocksLeft : MonoBehaviour
{
   public TextMeshProUGUI ScoreText;

    int Score=30;
    
    void Start()
    {
       ScoreText.text="Blocks Left "+Score.ToString();
    }



  public void UpdateTheBlocks(){
        
      Score=Score-1;
        

        ScoreText.text="Blocks Left "+Score.ToString();


        // ScoreTex.text="Block "+Score.ToString();

    }


    public void OnTheFloor(){

      ScoreText.text="Im on the floor!! ";


    }


public void InTheAir(){

      ScoreText.text="Im in the air ";


    }



}




