using UnityEngine;

public class ClickRoom : MonoBehaviour
{

    public Dialogue dialogueScript;
    public Azinos azinosScript;
    public YesNo optionScript;
    public Pause pauseScript;


    public PolygonCollider2D colliderBed;
    public BoxCollider2D colliderExit;
    public BoxCollider2D colliderPoster;


    // Update is called once per frame
    void Update()
    {
        if (dialogueScript.waiting == true || optionScript.waitingOption)
        {
            return;

            //colliderBed.enabled = false;
            //colliderExit.enabled = false;
            //colliderPoster.enabled = false;

        }
        //else
        //{
        //    colliderBed.enabled = true;
        //    colliderExit.enabled = true;
        //    colliderPoster.enabled = true;

        //}

        if (Input.GetMouseButtonDown(0) && pauseScript.isPaused == false)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider == colliderBed)
                {
                    azinosScript.OnBedClick();
                }

                if (hit.collider == colliderExit)
                {
                    azinosScript.OnExitClick();
                    optionScript.QuestionAsked();
                        
                }
                if (hit.collider == colliderPoster)
                {
                    azinosScript.OnPosterClick();
                }

            }
            else if (hit.collider == null)
            {
                azinosScript.OnNullClick();
            }

        }
    }
}
