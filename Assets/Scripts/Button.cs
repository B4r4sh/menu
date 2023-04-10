using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]

public class Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Animator _buttonAnimation;
    private int _animationHighlightedHash;
    private int _animationPressedHash;

    private void Start()
    {
        _buttonAnimation = GetComponent<Animator>();
        _animationHighlightedHash = Animator.StringToHash("isHighlighted");
        _animationPressedHash = Animator.StringToHash("isPressed");

    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        _buttonAnimation.SetBool(_animationHighlightedHash, true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _buttonAnimation.SetBool(_animationHighlightedHash, false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _buttonAnimation.SetTrigger(_animationPressedHash);
    }  
}
