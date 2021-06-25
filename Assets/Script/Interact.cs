using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Button[] CircleButtons;
    public Slider[] Sliders;
    //bool allClear = false;
    public GameObject Panel, Black;
    public Text ObjectiveText;
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
    }
    // Update is called once per frame
    void Update()
    {
        /*if (Sliders[0].value == 100 && Sliders[1].value == 100 && Sliders[2].value == 100 && Sliders[3].value == 100 && Sliders[4].value == 100) {
            allClear = true;
        }*/
    }

    public void CircleButton0() {
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
    }
    public void CircleButton6()
    {
        CircleButtons[6].image.color = Color.green;
       
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
        Application.LoadLevel(2);
    }
    public void EngineRoom()
    {
        Application.LoadLevel(7);
    }
    public void AlignWing()
    {
        Application.LoadLevel(6);
    }
    public void O2()
    {
        Application.LoadLevel(5);
    }
    public void FuelTank()
    {
        Application.LoadLevel(4);
    }
    public void Battery()
    {
        Application.LoadLevel(3);
    }
    public void Cockpit()
    {
        Application.LoadLevel(1);
    }
}
