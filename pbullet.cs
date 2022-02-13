using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pbullet : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
      transform.position += transform.up * Time.deltaTime * 10;
  }

  void FixedUpdate() {
    transform.position += transform.up * Time.deltaTime * 10;
    if (transform.position.y > 4f) {
      Destroy(this.gameObject);
    }
  }

  private void OnCollisionEnter2D(Collision2D collision) {
    Destroy(gameObject);
  }
}
