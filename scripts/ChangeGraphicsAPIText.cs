using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGraphicsAPIText : MonoBehaviour
{
    private TextMesh score_text;
    public PlayerScore scoreChangeNotifier;
    // Start is called before the first frame update
    void Start()
    {
        scoreChangeNotifier.onScoreChange += changeScore;
        scoreChangeNotifier.onScoreReward += resetScore;
        GameObject graphics_api_text = GameObject.FindWithTag("GraphicsAPIText");
        score_text = graphics_api_text.GetComponent<TextMesh>();
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
