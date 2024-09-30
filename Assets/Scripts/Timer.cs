using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public TextMeshProUGUI timerText;
    public GameObject winScreen;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = Mathf.Ceil(timeRemaining).ToString() + "s";
        }
        else
        {
            timeRemaining = 0;
            timerText.text = "0s";
            EndGame();
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("Win");
    }
}
