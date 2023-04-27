using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] GameObject screenToEnable;
    [SerializeField] GameObject screenToDisable;
    protected Main main;

    public virtual void SetScreen()
    {
            screenToEnable.SetActive(true);
            screenToDisable.SetActive(false);
        
    }
    public void CheckName()
    {
        if (main.name == "name")
        {
            main.errorText.text = "Please, enter your name";
            main.errorText.gameObject.SetActive(true);
        }
        else
        {
            SetScreen();
        }
    }

    private void Start()
    {
        main = GameObject.Find("Main").GetComponent<Main>();
    }
}

