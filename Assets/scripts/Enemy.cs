using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public GameObject effect;
  public  int hp = 3;
  public Transform Pl;
  public Transform P;
  public float speed;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector2.right * speed * Time.deltaTime);

      if(transform.position.x >= Pl.transform.position.x)
      {
        transform.localRotation = Quaternion.Euler(0, 180, 0);
      }

      if(transform.position.x <= P.transform.position.x)
      {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
      }

      if(hp <= 0)
      {
          Instantiate(effect, transform.position, transform.rotation);
          Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      hp -= damage;
    }
}
