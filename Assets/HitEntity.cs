using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    [SerializeField] int _damage;

    private void OnTriggerEnter(Collider entity)
    {
        print(entity.transform.parent.name);
        entity.transform.parent.GetComponent<EntityHealth>().TakeDamage(_damage);
    }

}
