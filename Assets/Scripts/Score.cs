using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        scoreText.text = "Coins: " + count.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coins"))
        {
            count++;
            scoreText.text = "Coins: " + count.ToString();
            Destroy(collision.gameObject);
        }
    }
}
