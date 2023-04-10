using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitFromMenuElement : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _parentGameObject;

    public void OnPointerClick(PointerEventData eventData)
    {
        _parentGameObject.SetActive(false);
    }
}
