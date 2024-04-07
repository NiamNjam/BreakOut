using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //builder pattern per taskeli
        /*
        transform.DOScale(new Vector3(2, 2, 2), 1f)
            .SetEase(Ease.OutBounce)
            .SetDelay(1f); //tween
        */
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.DOScale(Vector3.one * 1.3f, 0.2f)
            .SetEase(Ease.OutBounce)
            .SetLoops(2, LoopType.Yoyo)
            .ChangeStartValue(Vector3.one);
    }
}
