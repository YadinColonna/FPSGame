using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoramaControl : MonoBehaviour
{
    public CardUI[] allCards;
    public List<CardSO> showedCards = new List<CardSO>();

    public void OnShowCard(CardSO newShowedCard)
    {
        //Comparar con la ultima carta, y continuar dependiendo
        if (showedCards.Count == 0)
        {
            //Solo mostrar carta
            showedCards.Add(newShowedCard);
            return;
        }
        
        //Si ya se mostro una carta, asegurarse que sea igual a la anterior
        //Si el numero de cartas es 10, el index buscado es 10 -1 = 9
        CardSO lastShowed = showedCards[showedCards.Count - 1];

        if (lastShowed.cardValue == newShowedCard.cardValue &&
            lastShowed.type == newShowedCard.type)
        {
            //Solo mostrar la nueva carta
            //showedCards.Add(newShowedCard);     ya no se agrega, se limpia en cada par

            //Limpiar lista de cartas por cada par
            showedCards.Clear();
        }
        //Si no es igual
        else
        {
            //Ocultar de nuevo todas las cartas
            foreach (CardUI cardUI in allCards)
            {
                cardUI.Hide();
            }
            //Limpar lista de cartas al fallar
            showedCards.Clear();
        }
    }
    
    public static MemoramaControl Instance;
    public void Start()
    {
        Instance = this;
    }
}
