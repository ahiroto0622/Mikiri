using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    private CharacterUnit target;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    private void OnAttack()
    {
        //Collider2D[] hitenemies = Physics2D.OverlapCircleAll();
    }

    private void OnDamage()
    {

    }
}
