using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key1 : MonoBehaviour
{
  public GameObject key;
  public  GameObject ct;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other){
      if(other.tag == "key")
      {
        Destroy(ct);
        Destroy(key);
      }
    }
}
