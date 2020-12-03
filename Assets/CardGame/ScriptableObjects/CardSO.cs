using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CardData", menuName ="CardGame/CardData")]
public class CardSO : ScriptableObject
{
    public string cardName;
    public Sprite iconType;

    public int cardValue = 0;
    public CardType type;
}
