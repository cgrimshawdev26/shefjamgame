using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileBehaviour : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += -transform.up * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
      Destroy(gameObject);
    }
}
