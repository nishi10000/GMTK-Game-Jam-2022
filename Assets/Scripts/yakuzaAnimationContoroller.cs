using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yakuzaAnimationContoroller : MonoBehaviour
{
    Animator animator;
    [SerializeField]
    private string AnimationTransitionName= "NowShooting";

    // �X�^�[�g���ɌĂ΂��
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // �t���[�����ɌĂ΂��
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            animator.SetBool("NowShooting", true);
        }
        else
        {
            animator.SetBool("NowShooting", false);
        }
    }

    public void shooterAnimation()
    {
        animator.SetBool(AnimationTransitionName, true);
    }
    public void shooterAnimationEnd()
    {
        animator.SetBool(AnimationTransitionName, false);
    }
}
