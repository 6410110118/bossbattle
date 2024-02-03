using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int health;
    public float speed;
    public int damage;
    private float timeBtwDamage = 1.5f;

    public Animator camAnim;
    private Animator anim;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public Slider healthBar;
    public bool isDead;


    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);

        moveVelocity = moveInput.normalized * speed;

        if (moveInput != Vector2.zero)
        {
            anim.SetBool("isRunning", true);
        }
        else {
            anim.SetBool("isRunning", false);
        }

        

        if (health <= 10)
        {
            anim.SetTrigger("dead");
        }

        // give the player some time to recover before taking more damage !
        if (timeBtwDamage > 0)
        {
            timeBtwDamage -= Time.deltaTime;
        }

        healthBar.value = health;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    

}
