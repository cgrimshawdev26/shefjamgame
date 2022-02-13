using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;

    public void gameOver() {
      gameOverText.gameObject.SetActive(true);
      isGameActive = false;
      restartButton.gameObject.SetActive(true);
    }

    public void RestartGame() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Start is called before the first frame update
    void Start()
    {
      isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
