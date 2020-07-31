using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script : MonoBehaviour
{

    public Canvas canvasPanel = null;

    public Camera Player = null;

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
        canvasPanel.transform.position = Player.transform.position + (Player.transform.forward * 3);

        canvasPanel.transform.LookAt(transform.position + Player.transform.rotation * Vector3.back, Player.transform.rotation * Vector3.up);
        canvasPanel.transform.Rotate(0, 180, 0);

        canvasPanel.enabled = true;
    }


}
