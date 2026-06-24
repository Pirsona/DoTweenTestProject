using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _moveDirection;
    [SerializeField] private float _moveDuration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _moveEase;
    
    
    private void Start()
    {
        transform.DOMove(_moveDirection, _moveDuration).SetLoops(_repeats, _loopType).SetEase(_moveEase);
    }
}