using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTest : MonoBehaviour
{
    private Canvas canvas = null;
    private MenuManagerTest menuManager = null;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void Setup(MenuManagerTest menuManager)
    {
        this.menuManager = menuManager;
        this.Hide();

    }
    
    public void Show()
    {
        canvas.enabled = true;
    }

    public void Hide()
    {
       canvas.enabled = false;
    }
}
