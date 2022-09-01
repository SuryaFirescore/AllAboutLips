﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;
public class LevelObject : MonoBehaviour
{
    public P3dPaintableTexture lipsPaintable;
    public FracturedMesh fracturedMesh;

    void Start()
    {
        fracturedMesh.Init();
    }
}
