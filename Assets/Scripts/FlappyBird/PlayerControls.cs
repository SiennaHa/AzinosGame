using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    
    [SerializeField] float jumpForce;
    Rigidbody2D rb;

    Vector3 startPosition;


    public Animator animator;

    public SpriteRenderer spriteRenderer;
    public Sprite flap1;
    public Sprite flap2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform myTansform = transform;

        rb = GetComponent<Rigidbody2D>();

        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.gameStarted == true)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space pressed");
                Jump();
            }
        }
 
    }

    public void StartGame()
    {
        rb.linearVelocity = Vector3.zero;
        rb.gravityScale = 1;
        transform.position = startPosition;
    }

    void Jump()
    {
        Debug.Log("Jump");
        animator.SetTrigger("flap");
        rb.AddForce(Vector2.up * jumpForce);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag("Pipe"))
        {
            Debug.Log("Game Over");
            gameManager.GameOver();
        }
        if(collision.CompareTag("Goal"))
        {
            Debug.Log("Yay!");
            gameManager.PointScored();
        }
        if(collision.CompareTag("Fire"))
        {
            Debug.Log("burning");
            gameManager.spin = false;
        }
    }
}
