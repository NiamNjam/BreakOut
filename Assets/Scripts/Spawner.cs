using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject brick;
    public int horBricks;
    public int verBricks;
    public Vector2 brickSize;
    // Start is called before the first frame update
    async void Start()
    {
        for (int y = 0; y < verBricks; y++)
        {
            for (int x = 0; x < horBricks; x++)
            {
                var pos = new Vector3(x * brickSize.x, y * brickSize.y, 0);
                Instantiate(brick,transform.position + pos, Quaternion.identity);
                await new WaitForSeconds(0.1f);
            }
        }
    }

}
