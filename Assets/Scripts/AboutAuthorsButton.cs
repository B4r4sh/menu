using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutAuthorsButton : MonoBehaviour
{
    [SerializeField] private GameObject _authersPanel;
    private void Start()
    {
        _authersPanel.SetActive(false);
    }

    public void ClickOnButton()
    {
        _authersPanel.SetActive(true);
    }
}
