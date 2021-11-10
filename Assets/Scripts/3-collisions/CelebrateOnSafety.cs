using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class CelebrateOnSafety : MonoBehaviour {

    [Tooltip("Objects tagged with this tag will make the win the level on collision")]
    [SerializeField] string triggeringTag;
    [SerializeField] private float speed;
    private bool safe = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        safe = true;
        if (other.tag == triggeringTag && enabled)
        {
            safe = true;
        }
    }

    private void Update()
    {
        if (safe)
        {

            KeyboardMover keyboardMover = GetComponent<KeyboardMover>();
            keyboardMover.enabled = false;
            float x = (float)Mathf.Sin(speed*Time.time);
            float y = transform.position.y;
            float z = transform.position.z;
            transform.position = new Vector3(x, y, z);
        }
    }
}
