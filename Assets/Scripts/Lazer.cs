﻿using UnityEngine;

public class Lazer : MonoBehaviour
{
    private float _speed = 8.0f;

    void Update()
    {

        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if (transform.position.y >= 7)

            Destroy(gameObject);
    }
}
