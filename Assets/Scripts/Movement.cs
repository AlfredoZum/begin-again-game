using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rb;
    private float horizontal;
    private Animator anim;

    private Vector3 initPosition;
    private Vector3 secondPosition;

    [SerializeField] private GameObject floor;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        floor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PlayMovement();
        PlayerAnimation();
    }

    private void PlayMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(horizontal * speed * Time.deltaTime, 0, 0);
    }

    private void PlayerAnimation()
    {

        if (horizontal != 0)
        {
            // anim.SetBool("jump", false);
            anim.SetBool("runR", true);
            GetComponent<SpriteRenderer>().flipX = horizontal > 0 ? false : true;
        }
        else
        {
            anim.SetBool("runR", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.0001f)
        {
            // anim.SetBool("jump", true);
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            initPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            Debug.Log(initPosition.x);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            secondPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            // Debug.Log(secondPosition);
            Vector3 playerPosition = new Vector3( initPosition.x, initPosition.y, 0 );
            this.transform.position = playerPosition;

            floor.transform.position = new Vector3( secondPosition.x, secondPosition.y, 0 );
            floor.SetActive(true);


        }

        // if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.0001f){
        //     anim.SetBool("jump", true);
        //     rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        // } else {
        //     // anim.SetBool("jump", false);
        // }
    }

    //     private void JumpBtn() {
    //         rb.addForce(new Vector2(0, jumpForce), Force)
    //     }
}
