using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sbulletBehaviour : MonoBehaviour
{

    public float speed;
    public Rigidbody2D bullet;

    // Start is called before the first frame update
    void Start()
    {
        bullet.velocity = (GameObject.Find("player").transform.position - transform.position).normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
      Destroy(gameObject);
    }
}
