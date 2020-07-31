using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script_fixed : MonoBehaviour
{

    public Canvas canvasPanel = null;

    // Start is called before the first frame update
    void Start()
    {

        canvasPanel.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            canvasShow();
        }
    }

    public void canvasShow()
    {
        canvasPanel.enabled = true;
    }


}
