using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{

    public GameObject tier1Prefab;
    public GameObject tier2Prefab;
    public GameObject tier3Prefab;
    public GameObject tier4Prefab;
    public GameObject tier5Prefab;
    public GameObject tier6Prefab;
    public GameObject tier7Prefab;
    public float respawnTime;
    private Vector2 screenBounds;
    private int wave;
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyWave());
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void spawn(int wave){
      if (wave < 6) {
        switch (wave) {
          case 1:
            for (int i = 0; i < 6; i++) {
                GameObject a = Instantiate(tier1Prefab) as GameObject;
                a.transform.position = new Vector2(-2.7f+((5.4f/5f)*i), 5f);
            }
            break;
          case 2:
            for (int i = 0; i < 4; i++) {
                GameObject a = Instantiate(tier2Prefab) as GameObject;
                a.transform.position = new Vector2(-2f+((4f/3f)*i), 5f);
            }
            for (int i = 0; i < 4; i++) {
                GameObject a = Instantiate(tier2Prefab) as GameObject;
                a.transform.position = new Vector2(-2f+((4f/3f)*i), 6f);
            }
            for (int i = 0; i < 4; i++) {
                GameObject a = Instantiate(tier2Prefab) as GameObject;
                a.transform.position = new Vector2(-2f+((4f/3f)*i), 7f);
            }
            break;
          case 3:
            GameObject b = Instantiate(tier3Prefab) as GameObject;
            b.transform.position = new Vector2(0f, 5f);
            for (int i = 0; i < 4; i++) {
                GameObject a = Instantiate(tier1Prefab) as GameObject;
                a.transform.position = new Vector2(-2f+((4f/3f)*i), 9f);
            }
            break;
          case 4:
            for (int i = 0; i < 4; i++) {
                GameObject a = Instantiate(tier6Prefab) as GameObject;
                a.transform.position = new Vector2(-2f+((4f/3f)*i), 5f);
            }
            break;
          case 5:
            GameObject x = Instantiate(tier7Prefab) as GameObject;
            GameObject y = Instantiate(tier7Prefab) as GameObject;
            x.transform.position = new Vector2(-2.5f, 5f);
            y.transform.position = new Vector2(2.5f, 5f);
            break;
      }
    } else {
        for (int i = 1; i<(wave-4); i++) {
            GameObject s = Instantiate(tier1Prefab) as GameObject;
            s.transform.position = new Vector2(-2.25f, i*8f);
            GameObject d = Instantiate(tier1Prefab) as GameObject;
            d.transform.position = new Vector2(2.25f, i*8f);

            GameObject k = Instantiate(tier2Prefab) as GameObject;
            k.transform.position = new Vector2(-1.5f, i*10f);
            GameObject l = Instantiate(tier2Prefab) as GameObject;
            l.transform.position = new Vector2(-1f, i*10f);
            GameObject p = Instantiate(tier2Prefab) as GameObject;
            p.transform.position = new Vector2(-.5f, i*10f);
            GameObject u = Instantiate(tier2Prefab) as GameObject;
            u.transform.position = new Vector2(0, i*10f);

            GameObject t = Instantiate(tier3Prefab) as GameObject;
            t.transform.position = new Vector2(0, i*5f);

            GameObject r = Instantiate(tier6Prefab) as GameObject;
            r.transform.position = new Vector2(-1.75f, i*7f);
            GameObject c = Instantiate(tier6Prefab) as GameObject;
            c.transform.position = new Vector2(1.75f, i*7f);

            GameObject e = Instantiate(tier7Prefab) as GameObject;
            e.transform.position = new Vector2(-2.5f, i*12f);
            GameObject w = Instantiate(tier7Prefab) as GameObject;
            w.transform.position = new Vector2(2.5f, i*12f);
            respawnTime += 5;
        }
      }
    }

    IEnumerator enemyWave(){
        wave = 0;
        while(true){
            wave++;
            yield return new WaitForSeconds(respawnTime);
            spawn(wave);
            myText.text = "Wave :" + wave;
          }
        }
    }
