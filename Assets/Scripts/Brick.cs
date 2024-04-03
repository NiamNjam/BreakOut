using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField]public int hp = 1;
    public int score = 100;
    public Transform newPos;

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
