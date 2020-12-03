using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    public CardSO cardData;

    public GameObject front;
    public Text cardName;
    public Image cardIcon;
    public bool showing = false;

    public void Start()
    {
        //Si card data es nulo, no hacer nada
        if (cardData == null)
            return;

        cardName.text = cardData.cardName;
        cardIcon.sprite = cardData.iconType;
    }

    public void OnClick()
    {
        if (showing)
            return;

        StartCoroutine(OnShowCardCoroutine());
    }

    public IEnumerator OnShowCardCoroutine()
    {
        if (front != null)
            front.SetActive(false);

        showing = true;

        yield return new WaitForSeconds(0.7f);

        MemoramaControl.Instance.OnShowCard(cardData);
    }

    public void Hide()
    {
        front.SetActive(true);
        showing = false;
    }
}
