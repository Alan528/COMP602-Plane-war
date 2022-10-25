using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiedMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void mainmenu()
   {
       SceneManager.LoadScene("Menu"); //读取场景0
   }
   
   public void Restart()
    {
        SceneManager.LoadScene("game");
    }
}
