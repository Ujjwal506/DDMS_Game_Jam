using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargoController : MonoBehaviour
{
    // Start is called before the first frame update
    bool canMove;
    bool dragging;
    Collider2D collider;
    GameObject mainCamera;
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        collider = GetComponent<Collider2D>();
        canMove = false;
        dragging = false;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(mainCamera.GetComponent<LevelManager>().holdRecord);
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (collider == Physics2D.OverlapPoint(mousePos))
            {
                canMove = true;
            }
            else
            {
                canMove = false;
            }
            if (canMove)
            {
                dragging = true;
            }
        }
        if (dragging)
        {
            this.transform.position = mousePos;
        }
        if (Input.GetMouseButtonUp(0))
        {
            canMove = false;
            dragging = false;
        }
        if (mainCamera.GetComponent<LevelManager>().holdRecord == 4) {
            Debug.Log("All Clear");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collider.gameObject.tag == "Place") {
            mainCamera.GetComponent<LevelManager>().holdRecord++;
        }
    }
}
