using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private GameObject moveObject;
    [SerializeField] public float speed;
    [SerializeField] private Vector3 moveDirection = Vector3.zero;

    private void Update()
    {
        transform.position += moveDirection * speed * Time.deltaTime;
    }
    
    public void Moveto(Vector3 direction)
    {
        moveDirection = direction;
    }
}
