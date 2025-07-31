using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAzinos : MonoBehaviour
{
   
    public Dialogue dialogueScript;
    public Azinos azinosScript;
    public YesNo optionScript;


    public BoxCollider2D colliderEyes;
    public BoxCollider2D colliderHorns;
    public BoxCollider2D colliderBoobs;
    public BoxCollider2D colliderSnake;
    public BoxCollider2D colliderHair;

    //public GameObject allColliders;
    
    void Update()
    {
        if (dialogueScript.waiting == true || optionScript.waitingOption)
        {
            return;
            
            //colliderEyes.enabled = false;
            //colliderHorns.enabled = false;
            //colliderBoobs.enabled = false;
            //colliderSnake.enabled = false;
            //colliderHair.enabled = false;
        }
        //else
        //{
        //    colliderEyes.enabled = true;
        //    colliderHorns.enabled = true;
        //    colliderBoobs.enabled = true;
        //    colliderSnake.enabled = true;
        //    colliderHair.enabled = true;
        //}

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);


            if (hit.collider != null)
            {
                if (hit.collider == colliderEyes)
                {
                    azinosScript.OnEyesClicked();
                }

                if (hit.collider == colliderHorns)
                {
                    azinosScript.OnHornsClicked();
                }

                if (hit.collider == colliderBoobs)
                {
                    azinosScript.OnBoobsClicked();
                }

                if (hit.collider == colliderSnake)
                {
                    azinosScript.OnSnakeClicked();
                }

                if (hit.collider == colliderHair)
                {
                    azinosScript.OnHairClicked();
                }
            }
            else if (hit.collider == null)
            {
                azinosScript.OnNullClick();
            }
        }


    }



}
