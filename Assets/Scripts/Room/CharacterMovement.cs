using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Input.GetAxisRaw("Horizontal");
    }
}
