using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public Button[] CircleButtons;
    public Slider[] Sliders;
    //bool allClear = false;
    public GameObject Panel, Black,Quit;
    public Text ObjectiveText, Fly;
    public AudioSource rumble;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < LevelManager.Indicators.Length; i++) {
            if (LevelManager.Indicators[i] == true) {
                CircleButtons[i].image.color = Color.green;
            }
            else
                CircleButtons[i].image.color = Color.red;
        }
        if (LevelManager.Indicators[0] == true && LevelManager.Indicators[1] == true && LevelManager.Indicators[2] == true && LevelManager.Indicators[3] == true && LevelManager.Indicators[4] == true && LevelManager.Indicators[5] == true)
        {
            CircleButtons[6].image.color = Color.green;
            Fly.text = "      Take  Off";
        }
    }
    // Update is called once per frame
    void Update()
    {
        /*if (Sliders[0].value == 100 && Sliders[1].value == 100 && Sliders[2].value == 100 && Sliders[3].value == 100 && Sliders[4].value == 100) {
            allClear = true;
        }*/
    }

    /*public void CircleButton0() {
        CircleButtons[0].image.color = Color.green;       
    }
    public void CircleButton1()
    {
        CircleButtons[1].image.color = Color.green;
    }
    public void CircleButton2()
    {
        CircleButtons[2].image.color = Color.green;
    }
    public void CircleButton3()
    {
        CircleButtons[3].image.color = Color.green;
    }
    public void CircleButton4()
    {
        CircleButtons[4].image.color = Color.green;
    }
    public void CircleButton5()
    {
        CircleButtons[5].image.color = Color.green;
    }*/
    public void CircleButton6()
    {
        if (LevelManager.Indicators[0] == true && LevelManager.Indicators[1] == true && LevelManager.Indicators[2] == true && LevelManager.Indicators[3] == true && LevelManager.Indicators[4] == true && LevelManager.Indicators[5] == true)
        {
            rumble.Play();
            Quit.SetActive(true);
        }
    }
    public void Objective()
    {
        if (Panel.active == true)
        {
            Panel.SetActive(false);
            Black.SetActive(false);
            ObjectiveText.text = "Objective";
        }
        else
        {
            Panel.SetActive(true);
            Black.SetActive(true);
            ObjectiveText.text = "Back";
        }          
    }
    public void Cargo()
    {
        // SceneManager.LoadScene(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void EngineRoom()
    {
        SceneManager.LoadScene(7);
        
    }
    public void AlignWing()
    {
        SceneManager.LoadScene(6);
    }
    public void O2()
    {
        SceneManager.LoadScene(5);
    }
    public void FuelTank()
    {
        SceneManager.LoadScene(4);
    }
    public void Battery()
    {
        SceneManager.LoadScene(3);
    }
    public void Cockpit()
    {
        SceneManager.LoadScene(1);
    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
    public void MainMenu()
    {
        Application.LoadLevel(0);
    }
}
