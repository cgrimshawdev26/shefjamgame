using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankGun : MonoBehaviour
{
    public GameObject baseCircle;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(shoot());
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey("j")) {
        transform.RotateAround(baseCircle.transform.position, Vector3.forward, 150 * Time.deltaTime);
      } else if (Input.GetKey("l")) {
        transform.RotateAround(baseCircle.transform.position, Vector3.back, 150 * Time.deltaTime);
      }

    }

    IEnumerator shoot() {
      while (true)
      {
        GameObject a = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation) as GameObject;
        yield return new WaitForSeconds(.2f);
      }
    }
}
