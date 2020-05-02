using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UI;

public class HealthDisplay : MonoBehaviour
{
    TextMeshProUGUI healthText;
    GameSession gameSession;

    private void Update()
    {
        healthText.text = gameSession.GetHealth().ToString();
    }

    private void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>();
        gameSession = FindObjectOfType<GameSession>();
    }
}