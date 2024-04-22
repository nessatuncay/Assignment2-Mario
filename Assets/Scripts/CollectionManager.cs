using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectionManager : MonoBehaviour
{
    public TextMeshProUGUI gemUI;
    int numGemsCollected = 0;

    private void OnEnable()
    {
        Gem.OnGemCollected += GemCollected;
    }

    private void OnDisable()
    {
        Gem.OnGemCollected -= GemCollected;
    }

    private void GemCollected()
    {
        numGemsCollected++;
        gemUI.text = numGemsCollected.ToString();
    }
}
