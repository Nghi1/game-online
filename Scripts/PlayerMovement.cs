/*using UnityEngine;
using Fusion;

public class PlayerMovement : NetworkBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Animator animator;

    private Vector2 movement;

    public override void Spawned()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public override void FixedUpdateNetwork()
    {
        if (!HasInputAuthority) return;

        // Nhận input từ người chơi local
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(moveX, moveY).normalized;

        // Gửi input đến server (host)
        rb.linearVelocity = movement * moveSpeed;

        // Gửi animation sync cho mọi người
        RPC_SetAnimation(movement);
    }

    [Rpc(RpcSources.InputAuthority, RpcTargets.All)]
    void RPC_SetAnimation(Vector2 move)
    {
        if (animator == null) return;

        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.y);
        animator.SetFloat("Speed", move.sqrMagnitude);
    }
}*/
using Fusion;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
   // public Animator animator;
    [Networked, OnChangedRender(nameof(OnSpeedChanged))]
    public float AnimatorSpeed { get; set; }

    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnSpeedChanged()
    {
       // animator.SetFloat("Speed", AnimatorSpeed);
    }

    public Rigidbody2D rb;
    public float speed = 500f;

    public override void FixedUpdateNetwork()
    {
        var horizontal = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(horizontal, 0);
        rb.linearVelocity = move * speed * Runner.DeltaTime;

        AnimatorSpeed = rb.linearVelocity.magnitude;
    }
}






