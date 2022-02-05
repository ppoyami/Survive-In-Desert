using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeFSM : UnitBase
{
    public enum State
    {
        Idle,
        Walk,
        Attack,
        Hurt,
        Death
    }

    State currentState = State.Idle;
    Animator anim;

    public State CurrentState { get { return currentState; }
        set
        {
            Exit(currentState);
            Entry(value);
            currentState = value;
        }
    }

    protected override void Init()
    {
        base.Init();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        UpdateLogic();
    }
    // ======================= Update Logic =======================
    void UpdateLogic()
    {
        switch (currentState)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.Walk:
                UpdateWalk();
                break;
            case State.Attack:
                break;
            case State.Hurt:
                break;
            case State.Death:
                break;
            default:
                break;
        }
    }
    void UpdateIdle()
    {
        CurrentState = State.Walk;
    }
    void UpdateWalk()
    {
        transform.position += _speed * Time.deltaTime * _direction;
    }
    // ======================= Entry Logic =======================
    void Entry(State state)
    {
        switch (state)
        {
            case State.Idle:
                EntryIdle();
                break;
            case State.Walk:
                EntryWalk();
                break;
            case State.Attack:
                EntryAttack();
                break;
            case State.Hurt:
                EntryHurt();
                break;
            case State.Death:
                EntryDeath();
                break;
            default:
                break;
        }
    }
    
    void EntryIdle()
    {
        anim.SetBool("isIdle", true);
    }

    void EntryWalk() 
    {
        anim.SetBool("isWalk", true);
    }

    void EntryAttack()
    {
        anim.SetBool("isAttack", true);
    }

    void EntryHurt()
    {
        anim.SetBool("isHurt", true);
    }

    void EntryDeath()
    {
        anim.SetBool("isDeath", true);
    }
    // ======================= Exit Logic =======================
    void Exit(State state)
    {
        switch (state)
        {
            case State.Idle:
                ExitIdle();
                break;
            case State.Walk:
                ExitWalk();
                break;
            case State.Attack:
                ExitAttack();
                break;
            case State.Hurt:
                ExitHurt();
                break;
            case State.Death:
                ExitDeath();
                break;
            default:
                break;
        }
    }

    void ExitIdle()
    {
        anim.SetBool("isIdle", false);
    }

    void ExitWalk()
    {
        anim.SetBool("isWalk", false);
    }

    void ExitAttack()
    {
        anim.SetBool("isAttack", false);
    }

    void ExitHurt()
    {
        anim.SetBool("isHurt", false);
    }

    void ExitDeath()
    {
        anim.SetBool("isDeath", false);
    }
    // ======================= Behavior Logic =======================
}