using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spowncube : MonoBehaviour
{
    public GameObject cubePrefab;

    public void Cube()
    {
        Instantiate(cubePrefab);
    }
}
