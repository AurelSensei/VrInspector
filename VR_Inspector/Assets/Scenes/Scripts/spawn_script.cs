using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script : MonoBehaviour
{

    public Panel currentPanel = null;

    // Start is called before the first frame update
    void Start()
    {
        currentPanel.Hide();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            currentPanel.Show();
        }
    }

    public void canvasShow()
    {

    }

    public void canvasButtonHide()
    {
        currentPanel.Hide();
    }

}
