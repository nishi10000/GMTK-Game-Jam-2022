using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceAnimationController : MonoBehaviour
{
    [SerializeField]
    private GameObject targetobj;
    Rigidbody rigid;
    Animator animator;

    float speed;

    Vector3 latestPos;
    GameObject player;

    void Start()
    {
        player = targetobj;
        this.animator = GetComponent<Animator>();

    }

    void Update()
    {
        speed
          = ((player.transform.position - latestPos) / Time.deltaTime).magnitude;
        latestPos = player.transform.position;
        animator.SetFloat("Speed", speed);

    }

}
