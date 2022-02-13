using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tier7 : MonoBehaviour
{

    public Rigidbody2D body;
    private Vector2 screenBounds;
    public float speed;
    public GameObject bullet;
    public int maxHealth = 3;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        body.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        currentHealth = maxHealth;
        StartCoroutine(shoot());
        StartCoroutine(stopMove());
    }

    IEnumerator stopMove() {
      yield return new WaitForSeconds(1.5f);
      speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        if(-transform.position.y > screenBounds.y+20){
            Destroy(this.gameObject);
        }
        if(currentHealth<1){
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
      if (col.gameObject.name=="pbullet(Clone)") {
        currentHealth--;
      }
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(0, -speed);
    }

    IEnumerator shoot() {
      while (true)
      {
        GameObject a = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y-0.5f, transform.position.z), transform.rotation) as GameObject;
        yield return new WaitForSeconds(1);
      }
    }
}
