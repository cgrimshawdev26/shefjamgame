using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tier3 : MonoBehaviour
{

    public Rigidbody2D body;
    private Vector2 screenBounds;
    public float speed;
    public int maxHealth = 30;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        body.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if(-transform.position.y > screenBounds.y+20){
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(0, -speed);

        if(currentHealth<1){
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
      if (col.gameObject.name=="pbullet(Clone)") {
        currentHealth--;
      }
    }
}
