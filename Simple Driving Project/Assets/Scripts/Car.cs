using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float acc = 0.2f;
    // Update is called once per frame
    void Update()
    {
        speed += acc * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
