using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    void  OnTriggerEnter(Collider other)
    {
        ScoringSystem.coinScore += 1;
        Destroy(gameObject);
    }
}
