using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public int spdx, spdy, spdz;
    void Update()
    {
        transform.Rotate(spdx, spdy, spdz, Space.Self);
    }
}
