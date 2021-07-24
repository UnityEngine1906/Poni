using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
  public float speed = 10f;
  public  float life = 2;

    void Update()
    {
      transform.Translate(Vector2.right * speed * Time.deltaTime);
      life = life - Time.deltaTime;
      if(life <= 0){
        Destroy(gameObject);
      }
    }
    private void OnTriggerEnter2D(Collider2D other){
        Enemy en = other.GetComponent<Enemy>();
        if(en != null)
        {
          en.TakeDamage(1);
        }
        Destroy(gameObject);
    }
}
