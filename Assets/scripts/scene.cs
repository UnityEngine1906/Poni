using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    // Start is called before the first frame update
      public void Game1_back(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }

      public void Game1_back1(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
      }
}
