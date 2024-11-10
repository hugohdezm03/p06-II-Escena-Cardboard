using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggObjectController : MonoBehaviour
{
    public delegate void collectedEgg(GameObject egg);

    static public event collectedEgg onCollectedEgg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        onCollectedEgg(gameObject);
    }

    public void OnPointerExit()
    {
        TeleportEgg();
    }

    public void TeleportEgg()
    {
        float coordinate_x = Random.Range(-10.0f, 10.0f);
        float coordinate_z = Random.Range(-10.0f, 10.0f);
        GetComponent<Rigidbody>().MovePosition(new Vector3(coordinate_x, 0.5f, coordinate_z));
    }
}
