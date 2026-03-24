using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Animate : MonoBehaviour
{
    public Animator animate;

    void Start()
    {
        animate = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //  MOVE
        if(Input.GetKey(KeyCode.W))
        animate.SetBool("W_key_down", true);
        else
        animate.SetBool("W_key_down", false);

        if(Input.GetKey(KeyCode.S))
        animate.SetBool("S_key_down", true);
        else
        animate.SetBool("S_key_down", false);

        if(Input.GetKey(KeyCode.A))
        animate.SetBool("A_key_down", true);
        else
        animate.SetBool("A_key_down", false);

        if(Input.GetKey(KeyCode.D))
        animate.SetBool("D_key_down", true);
        else
        animate.SetBool("D_key_down", false);

        //  JUMP
        if(Input.GetKey(KeyCode.Space))
        animate.SetBool("Jump", true);
        else
        animate.SetBool("Jump", false);

        //  OTHER
        if(Input.GetKey(KeyCode.G))
        animate.SetBool("Dance", true);
        else
        animate.SetBool("Dance", false);
        
    }

    
}
