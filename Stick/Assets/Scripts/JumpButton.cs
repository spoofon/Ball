using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{
   
     StickMan The_Player;


    void Start()
    {

        The_Player=FindObjectOfType<StickMan>();
        
    }

  
     public void OnPointerDown(PointerEventData eventData){

       The_Player.Jump=true;
     

     }

     public void OnPointerUp(PointerEventData eventData){



        
     }



}
