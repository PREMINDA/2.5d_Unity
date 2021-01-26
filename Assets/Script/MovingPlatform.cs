using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private Transform _pointA;
    [SerializeField]
    private Transform _pointB;
    [SerializeField]
    private float _speed = 8.0f;
    private bool _ispodtion = true;
    [SerializeField]
    private GameObject _player;


    void Start()
    {
        Debug.Log("start");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_ispodtion == false)
        {

            transform.position = Vector3.MoveTowards(transform.position, _pointB.position, Time.deltaTime * _speed);
        }
        else if (_ispodtion == true)
        {

            transform.position = Vector3.MoveTowards(transform.position, _pointA.position, Time.deltaTime * _speed);
        }

        if (transform.position == _pointB.position)
        {
            _ispodtion = true;
        }
        else if (transform.position == _pointA.position)
        {
            _ispodtion = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           
            _player.transform.parent = this.transform;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            _player.transform.parent = null;

        }
    }
}
