using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string[] _newText;
    [SerializeField] private float _duration;
    [SerializeField] private ScrambleMode[] _scrambleMode;
    private void Start()
    {
        while (true)
        {
            int currentIndex = 0;
            
            foreach (string text in _newText )
            {
                _text.DOText(text,_duration,false,_scrambleMode[currentIndex]);
                currentIndex++;
            }
        }
    }
}
