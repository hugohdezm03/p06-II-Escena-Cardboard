using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class ChangeCanvasScore : MonoBehaviour
{
    public GameObject score_object;
    public TextMeshProUGUI score_text;

    public PlayerScore scoreChangeNotifier;
    // Start is called before the first frame update
    void Start()
    {
        scoreChangeNotifier.onScoreChange += changeScore;
        scoreChangeNotifier.onScoreReward += resetScore;
        if (score_object == null)
        {
            score_object = GameObject.FindWithTag("score_text");
        }
        score_text = score_object.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeScore(int score)
    {
        score_text.text = $"Puntuación Jugador => {score}";
    }

    void resetScore()
    {
        score_text.text = "Puntuación Jugador => 0";
    }
}
