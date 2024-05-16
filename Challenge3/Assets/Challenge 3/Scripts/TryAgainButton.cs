using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
    private PlayerControllerX playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playerControllerScript.point = 0;
        playerControllerScript.panel.SetActive(false);
        Physics.gravity = new Vector3(0f, -9.81f, 0f);
        Time.timeScale = 1;
    }
}
