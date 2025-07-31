using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class YesNo : MonoBehaviour
{
    public Azinos azinosScript;
    public Dialogue dialogueScript;

    public GameObject yes;    
    public GameObject no;    

    public BoxCollider2D colliderYes;
    public BoxCollider2D colliderNo;

    public bool waitingOption;


    void Start()
    {
        ToggleOptions(false);
    }


    void Update()
    {   
    
    
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider == colliderYes)
                {
                    Yes();
                    ToggleOptions(false);
                    waitingOption = false;
                }

                if (hit.collider == colliderNo)
                {
                    No();
                    ToggleOptions(false);
                    waitingOption = false;
                }
            }

        }


    }

    void ToggleOptions(bool show)
    {
        yes.SetActive(show);
        no.SetActive(show);
    }

    public void QuestionAsked()
    {
        StartCoroutine(WaitDialogue());

    }

    void Yes()
    {
        ToggleOptions(false);
        azinosScript.GoOut();

        StartCoroutine(WaitThenLeave());
    }


    void No()
    {
        ToggleOptions(false);
        azinosScript.Nevermind();
    }


    IEnumerator WaitThenLeave()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("FlappyBird");
    }
    
    IEnumerator WaitDialogue()
    {
        while (dialogueScript.waiting == true)
        {
            yield return null;
        }

        yield return new WaitForSeconds(1.0f);
        ToggleOptions(true);
        waitingOption = true;

    }
}
