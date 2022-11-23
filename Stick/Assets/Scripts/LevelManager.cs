using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // Invoke("LoadNextLevel",6);
    }

   
    


    private void LoadNextLevel(){



        GameManager.Instance.NextLevel();



    }





}
