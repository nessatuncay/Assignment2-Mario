using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gem : MonoBehaviour, ICollectible
{
    public static event Action OnGemCollected;
    public void Collect()
    {
        OnGemCollected?.Invoke();
        Debug.Log("Gem Collected!");
        Destroy(gameObject);
    }
}
