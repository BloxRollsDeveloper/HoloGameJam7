using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] private Animator _animator;
    
    public Rigidbody2D rb;
    public float moveSpeed = 5f;

    public float horizontalMovement;

    private void Start()
    {
        
    }
private void UpdateAnimation()
    {
        _animator = GetComponent<Animator>();

        if (horizontalMovement != 0f)
        {
            _animator.SetFloat("Horizontal", horizontalMovement);
             _animator.Play("Walk Tree");
        }
        else
        {
            _animator.Play("Idle Tree");
        }
    }
    private void Update()
    {
        UpdateAnimation();
        rb.linearVelocity = new Vector2(horizontalMovement * moveSpeed, rb.linearVelocity.y);
    }
    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
    }
    
}
