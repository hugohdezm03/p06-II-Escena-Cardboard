using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public delegate void scoreChange(int score);
    public event scoreChange onScoreChange;
    public delegate void scoreReward();
    public event scoreReward onScoreReward;
    public int red_egg_score = 5;
    public int green_egg_score = 10;
    public int player_score = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Suscripción al evento de recolección de huevos (estático)
        EggObjectController.onCollectedEgg += collectedEgg;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void collectedEgg(GameObject egg)
    {
        int earned_score = 0;
        switch(egg.tag)
        {
            case "eggs_group_1": earned_score = red_egg_score; break;
            case "eggs_group_2": earned_score = green_egg_score; break;
            default: earned_score = 0; break;
        }
        player_score += earned_score;
        Debug.Log("Player score: " + player_score);
        onScoreChange(player_score);

        if (player_score >= 100)
        {
            onScoreReward();
            player_score = 0;
        }
    }
}

