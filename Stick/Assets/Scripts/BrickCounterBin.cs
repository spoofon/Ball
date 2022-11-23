using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCounterBin : MonoBehaviour
{
    private BlocksLeft The_Blocks_Left;
    void Start()
    {
       The_Blocks_Left=FindObjectOfType<BlocksLeft>();
    }

private void OnTriggerEnter2D(Collider2D other)
    {

     

 if (other.transform.tag == "brick")
        {

     
     The_Blocks_Left.UpdateTheBlocks();

    

    }



}
}
