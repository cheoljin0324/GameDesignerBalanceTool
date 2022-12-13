using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameObject mainCanvas;
    [SerializeField]
    GameObject playerScroll;
    [SerializeField]
    GameObject weapownScroll;
    [SerializeField]
    GameObject shiledScroll;
    [SerializeField]
    GameObject Input;
    [SerializeField]
    GameObject InputButton;
    [SerializeField]
    GameObject view;
    [SerializeField]
    GameObject TestView;
 

    public void SetView()
    {
        view.gameObject.SetActive(true);
        weapownScroll.gameObject.SetActive(false);
        shiledScroll.gameObject.SetActive(false);
        Input.gameObject.SetActive(false);
        InputButton.gameObject.SetActive(false);
    }

    public void SetInput()
    {
        view.gameObject.SetActive(false);
        weapownScroll.gameObject.SetActive(true);
        shiledScroll.gameObject.SetActive(true);
        Input.gameObject.SetActive(true);
        InputButton.gameObject.SetActive(true);
    }
}
