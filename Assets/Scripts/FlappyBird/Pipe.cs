using UnityEngine;

public class Pipe : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float randomOffset;

    void Start()
    {
        Vector2 newPos = transform.position;
        newPos.y = Random.Range(-randomOffset, randomOffset);

        transform.position = newPos;
    }

    
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
        if(transform.position.x <= -100)
        {
            Destroy(gameObject);
        }

    }
}
