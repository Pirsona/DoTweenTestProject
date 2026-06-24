using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    
    [SerializeField] private Text _text;
    [SerializeField] private string _newText;
    [SerializeField] private string _addText;
    [SerializeField] private string _removeText;
    [SerializeField] private float _duration;
    [SerializeField] private ScrambleMode _scrambleMode;
    [SerializeField] private bool _richTextEnabled;
    [SerializeField] private int _loop;
    [SerializeField] private LoopType _loopType;
    
    private void Start()
    { 
        Sequence textSequence = DOTween.Sequence();
        
        textSequence.Append(_text.DOText(_newText, _duration));
        textSequence.AppendInterval(_duration);
        textSequence.Append(_text.DOText(" "  + _addText, _duration).SetRelative());
        textSequence.AppendInterval(_duration);
        textSequence.Append(_text.DOText(_removeText, _duration, _richTextEnabled, _scrambleMode));
        textSequence.SetLoops(_loop, _loopType);
    }
}