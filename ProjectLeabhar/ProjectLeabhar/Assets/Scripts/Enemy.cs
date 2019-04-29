using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger
}

public class Enemy : MonoBehaviour
{
    public EnemyState currentState;
    public FloatValue maxHealth;
    public float health;
    public string enemyName;
    public float baseAttack;
    public float moveSpeed;

    private void Start()
    {
        health = maxHealth.initialValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
