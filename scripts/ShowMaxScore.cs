using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMaxScore : MonoBehaviour
{
    private GameObject maxScoreReward;
    public PlayerScore scoreRewardNotifier;
    // Start is called before the first frame update
    void Start()
    {
        scoreRewardNotifier.onScoreReward += ShowMaxScoreText;
        maxScoreReward = GameObject.Find("MaxScoreReward");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowMaxScoreText()
    {
        maxScoreReward.GetComponent<MeshRenderer>().enabled = true;
        StartCoroutine(hideReward());
    }

    IEnumerator hideReward()
    {
        yield return new WaitForSeconds(0.5f);
        maxScoreReward.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        maxScoreReward.GetComponent<MeshRenderer>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        maxScoreReward.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        maxScoreReward.GetComponent<MeshRenderer>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        maxScoreReward.GetComponent<MeshRenderer>().enabled = false;
    }
}
