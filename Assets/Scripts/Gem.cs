using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour, ICollectible
{
    public void Collect()
    {
        Debug.Log("Gem Collected!");
        Destroy(gameObject);
    }
}
