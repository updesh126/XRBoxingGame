using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [SerializeField]
    GameObject SpawnManager;
    [SerializeField]
    GameObject GameOverMenu;

    cubePunch cube = new cubePunch();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bow")
        {
            SpawnManager.SetActive(false);
            GameOverMenu.SetActive(true);
        }
    }

    public void ResetGame(string Name)
    {
        SceneManager.LoadScene(Name);
        cube.speedrate(1.0f);
    }
}
