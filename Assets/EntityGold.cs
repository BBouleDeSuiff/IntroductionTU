using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EntityGold : MonoBehaviour
{
    [SerializeField] int goldCount;
    [SerializeField] Gold goldInfo;
    public event Action<int> GoldChanged;

    private void Awake()
    {

        goldInfo.AddGold += GoldInfo_AddGold;

    }

    public void GoldInfo_AddGold(int amount)
    {
        goldCount += amount;
        GoldChanged?.Invoke(goldCount);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
