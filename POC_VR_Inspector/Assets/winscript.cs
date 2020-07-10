using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winscript : MonoBehaviour
{
    public void Youwin()
    {
        GameManager.instance.Win();
    }
    
}
