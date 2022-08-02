﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    public Transform target;
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(target.position);
        Debug.Log("target is " + screenPos.x + " pixels from the left");
    }
}
