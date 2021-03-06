﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 playerVelocity;
    private float playerSpeed = 8.0f;
    [SerializeField]
    private float gravityValue = 1f;
    private bool _isground;
    private float _jumpHeight = 40f;
    private float _yVelocity;
    private bool isjump=false;
    private UIManager _uimanager;
    private int score=0;
    private int lives=3;




    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _uimanager = GameObject.Find("Canvas").GetComponent<UIManager>();

    }

    // Update is called once per frame
    void Update()
    {
       

        float horizon_dir = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(horizon_dir, 0, 0);

        Vector3 velocity = dir * playerSpeed;
       

        _isground = _controller.isGrounded;

        if (_isground == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _yVelocity = _jumpHeight;
                isjump = true;

            }

        }
        else
        {
            
                if (Input.GetKeyDown(KeyCode.Space) && isjump)
                {
                    _yVelocity += _jumpHeight+10f;
                    isjump = false;

                }
            
            _yVelocity -= gravityValue;
        }
        velocity.y = _yVelocity;
        _controller.Move(velocity * Time.deltaTime);
    }
    public void scoreadd()
    {
        score ++;
        _uimanager.getScore(score);
       


    }
    public void Damage()
    {
        lives--;
        _uimanager.updateLivers(lives);
        if(lives < 1)
        {
            SceneManager.LoadScene(0);
        }
    }

}

