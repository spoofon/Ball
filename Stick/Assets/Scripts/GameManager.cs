using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     public Canvas Game_Over_Text;

     public Canvas Next_Level_Text;

      private static GameManager _instance;


      private int Score;


       public static GameManager Instance
    {
        get { return _instance; }
    }
    



    // Start is called before the first frame update
    void Start()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;

            DontDestroyOnLoad(gameObject);
        }

        
    }

    
public void LoadLevelFirstLevel()
    {


        SceneManager.LoadScene(sceneBuildIndex: 1);

        


        Game_Over_Text.gameObject.SetActive(false);
    }


    private void LoadNextLevel()
    {


        SceneManager.LoadScene(sceneBuildIndex: 2);


        Next_Level_Text.gameObject.SetActive(false);
        

        
    }


  public void NextLevel(){


     Next_Level_Text.gameObject.SetActive(true);

     Invoke("LoadNextLevel",5);


  }



 public void GameOver()
    {


        Game_Over_Text.gameObject.SetActive(true);



        Invoke("LoadMenu", 2);


        

    }





    private void LoadMenu() {

           Game_Over_Text.gameObject.SetActive(false);

        SceneManager.LoadScene(sceneBuildIndex: 0);


    }



   public void SetScore(int score){



   }
    

    
   public int GetScore(){


    return Score;
   }


}
