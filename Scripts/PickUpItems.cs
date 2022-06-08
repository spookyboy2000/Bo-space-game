using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItems : MonoBehaviour
{
    [SerializeField]
    private Text DiamondCounter, AdamantiumCounter, VibraniumCounter;

    private int DiamondAmount, AdamantiumAmount, VibraniumAmount;
    // Start is called before the first frame update
    void Start()
    {
        DiamondAmount = 0;
        AdamantiumAmount = 0;
        VibraniumAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        DiamondCounter.text = "Diamonds: " + DiamondAmount;
        AdamantiumCounter.text = "Adamantiums: " + AdamantiumAmount;
        VibraniumCounter.text = "Vibraniums: " + VibraniumAmount;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<ItemScript>().itemType == ItemTypes.Diamond)
        {
            DiamondAmount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.GetComponent<ItemScript>().itemType == ItemTypes.Adamantium)
        {
            AdamantiumAmount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.GetComponent<ItemScript>().itemType == ItemTypes.Vibranium)
        {
            VibraniumAmount += 1;
            Destroy(collision.gameObject);
        }
    }
}
