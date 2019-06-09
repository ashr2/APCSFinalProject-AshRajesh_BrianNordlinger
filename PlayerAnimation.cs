using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {
    private Animator animator;
    public Transform pos;
    private int jump;
	// Use this for initialization
	void Start () {
        jump = 0;
        animator = GetComponent<Animator>();
        pos = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        
        float animateLocomotion = Input.GetAxis("Vertical")*4;
        if (jump == 0)
        {
            animator.SetFloat("Speed", animateLocomotion);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetFloat("Speed", 0.1f);
            animator.SetBool("Jump",true);
            jump = 1;
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Jump", false);
            animator.SetFloat("Speed", 0f);
            jump = 0;
        }
	}
}
