using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public Animator animator;
    [Header("Configuracion de Movimiento")]
    public float moveSpeed = 8f;
    public float jumpForce = 15f;

    private Rigidbody2D rb;
    private float horizontalInput;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
            horizontalInput = Input.GetAxisRaw("Horizontal");

            animator.SetFloat("Walking", horizontalInput * 0);
            animator.SetFloat("inAir", rb.linearVelocityY);

            if (horizontalInput < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                animator.SetFloat("Walking", -1*(horizontalInput * moveSpeed));
            }
            if (horizontalInput > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
                animator.SetFloat("Walking", horizontalInput * moveSpeed);
            }

            Vector3 posicion = transform.position;

            if (Input.GetButtonDown("Jump"))
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); 
            }

    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
    }

}
