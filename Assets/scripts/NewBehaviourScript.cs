using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  public  GameObject key;
  public  GameObject ct;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other){
      if(other.tag == "key2")
      {
        ct.SetActive(true);
        Destroy(key);
      }
    }
}
