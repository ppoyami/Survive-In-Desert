using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woodcutter : MeleeFSM
{
    private void Start()
    {
        Init();
    }

    protected override void Init()
    {
        base.Init();
        _health = 100.0f;
        _speed = 1.2f;
        _damage = 10.0f;
        _delay = 1.5f;
        _direction = Vector3.right;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            CurrentState = State.Attack;
        }
    }
}
