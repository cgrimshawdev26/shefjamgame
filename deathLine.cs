using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathLine : MonoBehaviour
{

    public playerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "enemy")
        {
           Debug.Log("damage");
           playerHealth.TakeDamage(1);
        }
    }
}
