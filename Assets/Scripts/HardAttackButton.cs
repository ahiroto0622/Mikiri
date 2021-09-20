using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardAttackButton : MonoBehaviour
{
    public GameObject player;
    private Animator anim;
    public bool isClick;
    private Vector2 localPos;

    void Start()
    {
        isClick = true;
        anim = player.GetComponent<Animator>();
        localPos = player.transform.localPosition;
    }

    public void OnButtonUp()
    {
        player.transform.localPosition = localPos;
    }

    public void OnButtonDown()
    {
        anim.SetTrigger("isHardAttack");
        player.transform.localPosition = new Vector3(localPos.x + 400, localPos.y);
    }


    void Update()
    {

    }
}
