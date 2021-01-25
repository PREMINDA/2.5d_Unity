using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Player playerobj = other.transform.GetComponent<Player>();
        if (other.tag == "Player")
        {
            playerobj.scoreadd();
            Destroy(this.gameObject);
            
            
        }
    }
}
