using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameObject EndScrin;

    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "PlayerTag")
        {
            if(ScoringSystem.coinScore>4)
            {
                EndScrin.gameObject.SetActive(true);
            }
        }
    }
}
