using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBase : MonoBehaviour
{
    [SerializeField]
    protected float _health;
    [SerializeField]
    protected float _speed;
    [SerializeField]
    protected float _damage;
    [SerializeField]
    protected float _delay;

    protected Vector3 _direction = Vector3.zero;

    protected virtual void Init()
    {
        
    }

}
