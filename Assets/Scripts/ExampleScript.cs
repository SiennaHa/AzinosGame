using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    //add VARIABLES
    //int - whole number... 1, 2, 3, 4
    //float - number with or without a decimal point... 0.5f, 1.6f, 90f
    //String - text/characters . use quotes for strings "hello", :goodbye"
    //bool - boolean, true or false (or conditions in if statements)

    //vector2 - variable that can store two floats
    //vector 3 - variable that can store three floats... x, y, z
    //rotation - eulerAngle is used to set the rotation in the inspector

    //color - colour

    //enums - different options to select from... settings menu graphics
    public EnumExample enumExample;
    public enum EnumExample
    {
        consumables,
        mainhand,
        offhand,
        helmet
    }


    //array, list, dictionary
    //bool[] myBoolArray
    //List<Bool> myBoolList
    //Dictionary<string, GameObject>


    //add REFERENCE type
    //GameObjects - the gameobjects withing the hierarchy or prefabs
    //Components - components attatched to gameobjects... transform, spriterender, etc.
    [SerializeField] GameObject triangleObj;
    [SerializeField] SpriteRenderer spriteRenderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
