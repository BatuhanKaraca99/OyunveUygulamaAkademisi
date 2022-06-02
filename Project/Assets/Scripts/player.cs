using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class player : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public Vector3 moveDelta;
    public Animator playerAnimator;
    public float x;
    public float y;
    AudioSource audioData;
    // Start is called before the first frame update
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        playerAnimator = GetComponent<Animator>();
        audioData = GetComponent<AudioSource>();
    }

    void Update()
    {
        playerAnimator.SetFloat("runx", Math.Abs(moveDelta.x));
        playerAnimator.SetFloat("runy", Math.Abs(moveDelta.y));
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        audioData.Pause();
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        //Reset MoveDelta
        moveDelta = new Vector3(x, y, 0);

        //Swap sprite direction, right or left
        if (moveDelta.x > 0)
        {
            transform.localScale = Vector3.one;
            audioData.Play(0);
        }
        else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            audioData.Play(0);
        }

        //Move
        transform.Translate(moveDelta * Time.deltaTime*2);

    }
}