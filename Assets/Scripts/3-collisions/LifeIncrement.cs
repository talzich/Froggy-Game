using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeIncrement : MonoBehaviour
{
    [Tooltip("Objects with this tag will increment the life field")]
    [SerializeField] string triggeringTag;
    [SerializeField] NumberField lifeField;
    [SerializeField] int pointsToIncrement;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag)
        {
            lifeField.AddNumber(pointsToIncrement);
        }
    }

    public void SetLifeField(NumberField newTextField)
    {
        this.lifeField = newTextField;
    }
}
