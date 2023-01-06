using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public virtual void ApplyEffect()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ApplyEffect();
            Destroy(gameObject);
        }
    }
}
