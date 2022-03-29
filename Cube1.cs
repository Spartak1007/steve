using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    // Start is called before the first frame update
    Transform cube_tr;
    void Start()
    {
        cube_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        cube_tr.Translate(1.1f, 1.01f, 1.01f);
    }
}
