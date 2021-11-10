using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeDecrement : MonoBehaviour
{
    [Tooltip("Objects with this tag will decrement the life field")]
    [SerializeField] string triggeringTag;
    [SerializeField] NumberField lifeField;
    [SerializeField] int pointsToDecrement;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag)
        {
            lifeField.AddNumber(-pointsToDecrement);
        }
    }

    public void SetLifeField(NumberField newTextField)
    {
        this.lifeField = newTextField;
    }
}
