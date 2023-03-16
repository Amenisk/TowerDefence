using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CripMenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Transform cripMessage;

    public void OnPointerEnter(PointerEventData eventData)
    {
        cripMessage.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        cripMessage.gameObject.SetActive(false);
    }
}
