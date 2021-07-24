using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class walk : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float jumpForce = 15f;

    public bool isGround = false;
    public float checkRadius;
    public Transform checkPoz;
    public LayerMask ground;
    public Transform Resp;
    public int JumpCol;

    Animator anim;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }
    void Update()
    {

        isGround = Physics2D.OverlapCircle(checkPoz.position, checkRadius, ground);
        if (Input.GetButton("Horizontal"))
            Run();
        if (Input.GetKeyDown(KeyCode.W) && JumpCol > 0)
            Jump();
            Flip();

        if (isGround == true) {
            JumpCol = 1;
        }
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        isGround = false;
        JumpCol--;
    }
    void Flip()
    {
      if(Input.GetAxis("Horizontal") < 0)
        transform.localScale = new Vector3(0.2808302f, 0.2808302f, 0.05f);
      if(Input.GetAxis("Horizontal") > 0)
        transform.localScale = new Vector3(-0.2808302f, 0.2808302f, 0.05f);

      if(Input.GetAxis("Horizontal") == 0)
      {
        anim.SetBool("isrun", true);
      }

      else
      {
        anim.SetBool("isrun", false);
      }
    }
    private void OnTriggerEnter2D(Collider2D other){
      if (other.tag == "Enemy") {
        transform.position = Resp.position;
      }
      if(other.tag == "tp1")
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
      }
    }
}
