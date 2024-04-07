using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Shake : MonoBehaviour
{
    public GameObject screen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        screen.transform.DOShakePosition(0.5f, 0.2f);
    }
}
