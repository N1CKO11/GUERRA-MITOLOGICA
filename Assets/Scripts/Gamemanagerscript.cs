using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanagerscript : MonoBehaviour
{
    public GameObject pausemenu;
    public void pausebutton()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void playbutton()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1;
    }
}
