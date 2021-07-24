using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
  public float shotTime;
  public float startTime;
  public GameObject effect;
  public GameObject bullet;
  public Transform poz;

    void Update()
    {
         if(Input.GetAxis("Horizontal") < 0)
            // transform.localScale = new Vector3(-1f, 1f, 1f);
            transform.localRotation = Quaternion.Euler(0,180,0);
          if(Input.GetAxis("Horizontal") > 0)
            // transform.localScale = new Vector3(1f, 1f, 1f);
            transform.localRotation = Quaternion.Euler(0,0,0);

            if(shotTime <= 0)
            {
              if(Input.GetMouseButton(0))
              {
                Instantiate(effect, poz.position, poz.rotation);
                Instantiate(bullet, poz.position, poz.rotation);
                shotTime = startTime;
              }
            }
            else
            {
                shotTime -= Time.deltaTime;
            }
    }
}
