using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderToEgg : MonoBehaviour
{
    private static int red_spiders_counter = 0;
    private static int green_spiders_counter = 0;
    private Vector3 red_spiders_reference;
    private Vector3 green_spiders_reference;
    public PlayerScore scoreRewardNotifier;
    // Start is called before the first frame update
    void Start()
    {
        scoreRewardNotifier.onScoreReward += ScoreRewardMove;
        red_spiders_reference = GameObject.FindWithTag("eggs_group_1").transform.position;
        green_spiders_reference = GameObject.FindWithTag("eggs_group_2").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ScoreRewardMove()
    {
        red_spiders_reference = GameObject.FindWithTag("eggs_group_1").transform.position;
        green_spiders_reference = GameObject.FindWithTag("eggs_group_2").transform.position;


        if (red_spiders_counter >= GameObject.FindGameObjectsWithTag("spiders_group_1").Length)
        {
            red_spiders_counter = 0;
        }

        if (green_spiders_counter >= GameObject.FindGameObjectsWithTag("spiders_group_2").Length)
        {
            green_spiders_counter = 0;
        }

        switch(gameObject.tag)
        {
            case "spiders_group_1": {
                Vector3 new_position = new Vector3(0.0f + (red_spiders_counter * 5.5f), 0.0f, -2.5f);
                gameObject.GetComponent<Rigidbody>().MovePosition(new_position + red_spiders_reference);
                SpiderToEgg.red_spiders_counter++;
                break;
            }
            case "spiders_group_2": {
                Vector3 new_position = new Vector3(0.0f + (green_spiders_counter * 5.5f), 0.0f, -2.5f);
                gameObject.GetComponent<Rigidbody>().MovePosition(new_position + green_spiders_reference);
                SpiderToEgg.green_spiders_counter++;
                break;
            }
            default: Debug.Log("No se ha encontrado el tag del objeto"); break;
        }
    }
}
