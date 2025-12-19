using UnityEngine;
using System;
using PurrNet;

public class TestNetwork : NetworkIdentity
{
    [SerializeField] private Color _color;
    [SerializeField] private Renderer _renderer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            SetColor();
    }

    [ObserversRpc]
    private void SetColor()
    {
        _renderer.material.color = _color;
    }
}
