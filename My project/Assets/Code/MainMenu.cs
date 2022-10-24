using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //要使用SceneManager的話，最上方要先引入UnityEngine.SceneManagement名稱空間
public class MainMenu : MonoBehaviour
{

    public void Newgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//自动读取下一关
    }
    public void Quit()
    {
        Application.Quit();
    }
}
 
