using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthHandle : MonoBehaviour
{
    public TextMeshProUGUI hptext;
    public int health;

    private void Update()
    {
        hptext.text = $"HP: {health}";
    }
}
