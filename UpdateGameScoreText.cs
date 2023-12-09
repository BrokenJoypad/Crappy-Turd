using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateGameScoreText : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = GameManager.Instance;
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = gameManager.ReturnScore().ToString();
    }
}
