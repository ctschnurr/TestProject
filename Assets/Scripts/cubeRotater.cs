using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRotater : MonoBehaviour
{

    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Rotate(0, 5, 0);
    }
}
