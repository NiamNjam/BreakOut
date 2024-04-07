using UnityEngine;
using DG.Tweening;

public class Brick : MonoBehaviour
{
    [SerializeField]public int hp = 1;
    public int score = 100;
    public Transform newPos;
    public GameObject screen;

    async void Start()
    {
        //transform.localScale = Vector3.zero;
        await transform.DOScale(Vector3.one, 0.5f)
            .ChangeStartValue(Vector3.zero)
            .SetDelay(Random.Range(0f, 1f))
            .SetEase(Ease.OutExpo)
            .AsyncWaitForCompletion();

        //transform.DORotate( new Vector3(0,0, 360f), 1f, RotateMode.WorldAxisAdd);
    }

    public void Damage()
    {
        hp--;
        if (hp <= 0)
        {
            //gameObject.transform.position = new Vector3(0, 0, 0);
            Destroy(gameObject);
            GameManager.score += score;
        }
    }

}
