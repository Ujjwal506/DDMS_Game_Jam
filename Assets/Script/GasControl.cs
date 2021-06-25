using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasControl : MonoBehaviour
{
    public Slider o2, co2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (o2.value == 100 && co2.value == 100) {
            if (LevelManager.Indicators[1] == false && LevelManager.Indicators[2] == true && LevelManager.Indicators[0] == true && LevelManager.Indicators[4] == true && LevelManager.Indicators[5] == false)
            {
                LevelManager.Indicators[3] = true;
            }
        }
    }
}
