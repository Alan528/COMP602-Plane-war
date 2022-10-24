using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //要使用SceneManager的話，最上方要先引入UnityEngine.SceneManagement名稱空間

public class Pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //公开静态 判断为false(你总不能进游戏就是暂停吧？
    public GameObject pauseMenuUI; //暂停UI

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //%#Q： 快捷键设置，Ctrl=% Shift=# GetKeyDown(KeyCode) 获取键盘按键按下 强调的是瞬间发生的动作  ,Input.GetKey(KeyCode)键盘按键按住不放,Input.GetKeyUp(KeyCode)键盘按键松开
      {  
          if (GameIsPaused)
         {
              Resume();   //如果是暂停了,再按一次就恢复了
         }
         else
         {
             Pause();   //如果没暂停，那就暂停
         }     
    }
 }
        public void Resume()
         {
             pauseMenuUI.SetActive(false); //暂停页面 OFF
             Time.timeScale = 1.0f; //理论上，我是不是还能搞个子弹时间？
             GameIsPaused = false; //关闭了暂停

         }

         public void Pause()
         {
             pauseMenuUI.SetActive(true); //暂停页面 on
             Time.timeScale = 0.0f; //时间流速，0为全停
             GameIsPaused = true; //打开了暂停
         }
  
   public void mainmenu()
   {
       Time.timeScale = 1.0f; //理论上，我是不是还能搞个子弹时间？
       GameIsPaused = false; //关闭了暂停
       SceneManager.LoadScene("Menu"); //读取场景0
   }
   
   public void Quit()
    {
        Application.Quit();
    }
}
 
