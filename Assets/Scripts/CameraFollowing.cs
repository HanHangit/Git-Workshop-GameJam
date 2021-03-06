﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    [SerializeField]
    private Transform _player = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = Vector2.Lerp(
                new Vector2(transform.position.x, transform.position.y),
                new Vector2(_player.position.x, _player.position.y + 3.0f),
                0.01f);
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }
}
