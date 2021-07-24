using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{

  public float shotTime;
  public float startTime;


    void Update()
    {
      if(shotTime <= 0)
      {
        Destroy(gameObject);
      }
      else
      {
          shotTime -= Time.deltaTime;
      }
    }
}
