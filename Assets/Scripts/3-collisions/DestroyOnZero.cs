using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DestroyOnZero : MonoBehaviour
{
    [Tooltip("Objects with this tag will remove 1 life")]
    [SerializeField] private string triggeringTag;
    [SerializeField] private int numberOfLives;
    [SerializeField] NumberField lifeField;

    public void Start()
    {
        lifeField.SetNumber(numberOfLives);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            if(lifeField.GetNumber() <= 0)
            {
                Destroy(this.gameObject);
            }
            Destroy(other.gameObject);
        }
    }
}
