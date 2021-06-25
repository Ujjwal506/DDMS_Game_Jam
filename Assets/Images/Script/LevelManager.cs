using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int holdRecord;
    public static bool[] Indicators = { false, false, false, false, false, false };
    void Start()
    {
        holdRecord = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
