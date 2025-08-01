/*using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    private Animator animator;
    private int go;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)  || Input.GetKey(KeyCode.DownArrow))
          go = -1;
        else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow))
            go = 1;
            else 
            go = 0;

            if(Input.GetKey(KeyCode.LeftArrow)  || Input.GetKey(KeyCode.RightArrow))
          transform.Translate(Vector3.right*go*Time.deltaTime);
          else if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.right*go*Time.deltaTime);

       
    }
}*/
/*using UnityEngine;
using Fusion;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(NetworkTransform))]
public class PlayerController : NetworkBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    public override void Spawned()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    public override void FixedUpdateNetwork()
    {
        if (Object.HasInputAuthority)
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            Vector2 direction = new Vector2(horizontal, vertical).normalized;
            rb.linearVelocity = direction * moveSpeed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}*/



