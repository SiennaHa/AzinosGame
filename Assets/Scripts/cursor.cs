using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class cursor : MonoBehaviour
{

    public SpriteRenderer spriteRenderer; 
    public Sprite cursorDefault;
    public Sprite cursorClick;

    private void Start()
    {
        UnityEngine.Cursor.visible = false;
        
    }

    public void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);


        if (Input.GetMouseButton(0))
        {
            spriteRenderer.sprite = cursorClick;
        }
        else
        {
            spriteRenderer.sprite = cursorDefault;
                
        }

    }



}
