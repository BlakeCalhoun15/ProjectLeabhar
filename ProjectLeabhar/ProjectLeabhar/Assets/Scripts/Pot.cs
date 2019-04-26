﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destroy()
    {
        anim.SetBool("smash", true);
        StartCoroutine(BreakCo());
    }

    //turns the object off in the game so that when it is destroyed, its no longer visible
    IEnumerator BreakCo()
    {
        yield return new WaitForSeconds(1f);
        this.gameObject.SetActive(false);
    }
}