using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]

public class Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Animator _buttonAnimation;

    void Start()
    {
        _buttonAnimation = GetComponent<Animator>();
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        _buttonAnimation.SetBool("isHighlighted", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _buttonAnimation.SetBool("isHighlighted", false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _buttonAnimation.SetTrigger("isPressed");
    }  
}
