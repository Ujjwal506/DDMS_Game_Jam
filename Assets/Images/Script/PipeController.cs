using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    // Start is called before the first frame update
    bool canMove;
    bool dragging;
    Collider2D collider;
    public GameObject indicator;
    void Start()
    {
        collider = GetComponent<Collider2D>();
        canMove = false;
        dragging = false;
    }
    // Update is called once per frame
    void Update()
    {
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
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Fuel Tank")
        {
            indicator.GetComponent<SpriteRenderer>().color=Color.green;
            if (LevelManager.Indicators[1] == false && LevelManager.Indicators[0] == false && LevelManager.Indicators[3] == false && LevelManager.Indicators[4] == true && LevelManager.Indicators[5] == false)
            {
                LevelManager.Indicators[2] = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Fuel Tank")
        {
            indicator.GetComponent<SpriteRenderer>().color = Color.red;
            LevelManager.Indicators[2] = false;
        }
    }
}
