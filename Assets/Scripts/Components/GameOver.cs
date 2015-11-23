using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject menu;
    public GameObject replay;

    public GameObject gameOverText;

    public void EndGame()
    {
        menu.SetActive(true);
        replay.SetActive(true);

        gameOverText.SetActive(true);
    }
}
