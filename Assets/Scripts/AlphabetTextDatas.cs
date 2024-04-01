using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "AlphabetTextDatas", menuName = "ScriptableObjects/AlphabetTextDatas")]
public class AlphabetTextDatas : ScriptableObject
{
    [SerializeField]
    public List<AlphabetTextData> _data;
}
