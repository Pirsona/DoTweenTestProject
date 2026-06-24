using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _rotateDuration;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _rotateEase;

    private void Start()
    {
        transform.DORotate(_rotation, _rotateDuration, _rotateMode).SetLoops(_repeats, _loopType).SetEase(_rotateEase);
    }
}