using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 playerVelocity;
    private float playerSpeed = 5.0f;
    [SerializeField]
    private float gravityValue = 1f;
    private bool _isground;
    private float _jumpHeight = 40f;
    private float _yVelocity;
    private bool isjump=false;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        
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
                    _yVelocity += _jumpHeight+15f;
                    isjump = false;

                }
            
            _yVelocity -= gravityValue;
        }
        velocity.y = _yVelocity;
        _controller.Move(velocity * Time.deltaTime);
    }
}
