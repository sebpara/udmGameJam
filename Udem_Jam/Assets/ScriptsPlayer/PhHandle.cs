using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PhHandle : MonoBehaviour
{
    public TextMeshProUGUI phtext;
    public int ph;

    private void Update()
    {
        phtext.text = $"Ph: {ph}";
    }
}
