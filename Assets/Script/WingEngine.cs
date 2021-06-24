using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingEngine : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 rotation;
    void Start()
    {
        rotation = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
    public void Fire0() {
        rotation = new Vector3(0, 0, 30);
    }
    public void Fire1()
    {
        rotation = new Vector3(0, 0, 150);
    }
    public void Fire2()
    {
        rotation = new Vector3(0, 0, 300);
        LevelManager.Indicators[5] = true;
    }
}
