using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;

    private Renderer _renderer;
    
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        
        _renderer.material.DOColor(_color, _duration);
    }
}