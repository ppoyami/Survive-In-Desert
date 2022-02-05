using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyena : MeleeFSM
{
    private void Start()
    {
        Init();
    }

    protected override void Init()
    {
        base.Init();
        _health = 30.0f;
        _speed = 2.0f;
        _damage = 5.0f;
        _delay = 0.6f;
        _direction = Vector3.left;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Unit"))
        {
            CurrentState = State.Attack;
        }
    }
}
