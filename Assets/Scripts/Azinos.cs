using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azinos : MonoBehaviour
{
    public Dialogue dialogueScript;

    public SpriteRenderer spriteRender;
    public Sprite[] spriteArray;

    public int annoyance;

    void Start()
    {
        spriteRender.sprite = spriteArray[0];
        annoyance = 0;
    }


    //outside - yes or no
    public void GoOut()
    {
        spriteRender.sprite = spriteArray[14];
        dialogueScript.indexStart = 9;
        dialogueScript.StartAzinosDialogue();
    }
    public void Nevermind()
    {
        spriteRender.sprite = spriteArray[5];
        dialogueScript.indexStart = 8;
        dialogueScript.StartAzinosDialogue();
    }

    //on click azinos stuff
    public void OnEyesClicked()
    {
        Debug.Log("eyes");
        spriteRender.sprite = spriteArray[12];
        dialogueScript.indexStart = 0;
        dialogueScript.StartAzinosDialogue();

        annoyance++;
    }

    public void OnHornsClicked()
    {
        Debug.Log("horns");
        spriteRender.sprite = spriteArray[1];
        dialogueScript.indexStart = 1;
        dialogueScript.StartAzinosDialogue();

        annoyance++;
    }
    public void OnBoobsClicked()
    {
        Debug.Log("AH");
        spriteRender.sprite = spriteArray[7];
        dialogueScript.indexStart = 2;
        dialogueScript.StartAzinosDialogue();

        annoyance++;
    }
    public void OnSnakeClicked()
    {
        Debug.Log("snake");
        spriteRender.sprite = spriteArray[1];
        dialogueScript.indexStart = 3;
        dialogueScript.StartAzinosDialogue();

        annoyance--;
    }
    public void OnHairClicked()
    {
        Debug.Log("hair");
        spriteRender.sprite = spriteArray[4];
        dialogueScript.indexStart = 4;
        dialogueScript.StartAzinosDialogue();

        annoyance++;
    }
    public void OnNullClick()
    {
        Debug.Log("out");
        spriteRender.sprite = spriteArray[0];
        dialogueScript.EndDialogue();

        annoyance++;
    }


    //room stuff
    public void OnBedClick()
    {
        Debug.Log("bed");
        spriteRender.sprite = spriteArray[15];
        dialogueScript.indexStart = 5;
        dialogueScript.StartAzinosDialogue();
    }
    public void OnExitClick()
    {
        Debug.Log("exit");
        spriteRender.sprite = spriteArray[4];
        dialogueScript.indexStart = 6;
        dialogueScript.StartAzinosDialogue();
    }
    public void OnPosterClick()
    {
        Debug.Log("poster");
        spriteRender.sprite = spriteArray[10];
        dialogueScript.indexStart = 7;
        dialogueScript.StartAzinosDialogue();
    }

}
