using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private Text scoreText;


    private void Start()
    {
        scoreText = GetComponent<Text>();    
    }

    public void UpdateScoreText(int value)
    {
        scoreText.text = value.ToString();
    }
}
