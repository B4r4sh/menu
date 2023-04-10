using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private GameObject _playImage;

    private void Start()
    {
        _playImage.SetActive(false);
    }

    public void OnButtonClick()
    {
        _playImage.SetActive(true);
    }
}
