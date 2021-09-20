using UnityEngine;
using UnityEngine.UI;

public class DefenceButton : MonoBehaviour
{
    public GameObject player;
    private Animator anim;

    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

    public void OnButtonUp()
    {
        
    }

    public void OnButtonDown()
    {
        anim.SetTrigger("isDefence");
    }


    void Update()
    {

    }
}
