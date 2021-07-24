using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

  public  Transform plTr;
  public  string plTag;
  public  float speed;


  public  void Awake()
  {
    this.plTag = "Player";
    if(this.plTr == null)
    {
      if(this.plTag == "")
      {
        this.plTag = "Player";
      }
      this.plTr = GameObject.FindGameObjectWithTag(this.plTag).transform;
    }

    this.plTr.position = new Vector3()
    {
      x = this.plTr.position.x,
      y = this.plTr.position.y,
      z = this.plTr.position.z - 10
    };
  }

  public  void Update()
  {
    if(this.plTr)
    {
      Vector3 target = new Vector3()
      {
        x = this.plTr.position.x,
        y = this.plTr.position.y,
        z = this.plTr.position.z - 10
      };

      Vector3 poz = Vector3.Lerp(this.transform.position, target, this.speed * Time.deltaTime);
      this.transform.position = poz;
    }
  }
}
