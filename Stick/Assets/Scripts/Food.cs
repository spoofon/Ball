using UnityEngine;

public class Food : MonoBehaviour
{
   
private Vector3 OldPosition;

   
void Start()
    {
        

     OldPosition= new Vector3(transform.position.x,transform.position.y,transform.position.z);


    }


 private void OnTriggerEnter2D(Collider2D other)
    {

     
     if (other.transform.tag == "Player")
        {
             transform.position= new Vector3(100,100,0);



            // Invoke("ReSpawn",4);
        }
    
     

    }


private void ReSpawn(){



transform.position=OldPosition;



}

}
