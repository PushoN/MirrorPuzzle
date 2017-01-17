﻿using UnityEngine;
using System.Collections;

public class EmitterColor : MonoBehaviour
{

    public PhotonEmitter PhotonEmitter;
    public MeshRenderer MeshRenderer;

    void Start()
    {
        SetColor(Util.GetColor(PhotonEmitter.Wavelength));
    }

    public void SetColor(Color color)
    {
        MeshRenderer.material.color = color;
    }
}