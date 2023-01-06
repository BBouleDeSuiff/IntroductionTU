using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Gold : Item
{

    [SerializeField] int goldAmount;
    [SerializeField] EntityGold playergold;
    public event Action<int> AddGold;

    public override void ApplyEffect()
    {
        GameObject.FindGameObjectWithTag("Player")?.GetComponent<EntityGold>()?.GoldInfo_AddGold(goldAmount);
        AddGold?.Invoke(goldAmount);

    }

}
