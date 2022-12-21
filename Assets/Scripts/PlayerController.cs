using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    AudioSource music;
  
    void Start()
    {
        animator = GetComponent<Animator>();
        music = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("walk", true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {//not pressed
            animator.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("run", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {//not pressed
            animator.SetBool("run", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool("speedrun", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {//not pressed
            animator.SetBool("speedrun", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
            music.Play();
        }
        
        
    }

}
