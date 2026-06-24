using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _durationScale;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _moveEase;
    
    private void Start()
    {
        transform.DOScale(_scale, _durationScale).SetLoops(_repeats, _loopType).SetEase(_moveEase);
    }
}