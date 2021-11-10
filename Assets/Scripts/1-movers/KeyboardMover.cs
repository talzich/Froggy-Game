using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class KeyboardMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 2f, 0));
        }
    }
}
