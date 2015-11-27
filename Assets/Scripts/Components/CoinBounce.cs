//Written by Niek Schoone
using UnityEngine;
using System.Collections;

public class CoinBounce : MonoBehaviour
{
    private float bounceSpeedY;
    private float bounceSpeedX;
    private float bounceHeight;
    private int bounceAmount;
    private float bounceTime;
    private float startTime;

    private Vector2 localPos;

    private Collider2D collider;

    void Start()
    {
        bounceSpeedX = Random.Range(1.5f, 2.5f);
        bounceSpeedY = Random.Range(0.5f, 1.5f);
        bounceHeight = Random.Range(1.5f, 2.5f);
        bounceAmount = Random.Range(1, 3);

        startTime = Time.time;

        collider = GetComponent<Collider2D>();
        collider.enabled = false;

        localPos = new Vector2(transform.position.x, transform.position.y);

        StartCoroutine(Bounce());
    }

    IEnumerator Bounce()
    {
        for (int i = 0; i < bounceAmount; i++)
        {
            bounceTime = 0;
            while (bounceTime < 1)
            {
                //Get the time since the coroutine started
                float localTime = Time.time - startTime;
                bounceTime += Time.deltaTime * bounceSpeedY;
                transform.position = new Vector2(localPos.x + bounceSpeedX * localTime, localPos.y + BounceMath(bounceTime) * bounceHeight);
                yield return null;
            }
            bounceHeight--;
        }
        collider.enabled = true;
    }

    float BounceMath(float t)
    {
        return Mathf.Sin(Mathf.Clamp01(t) * Mathf.PI);
    }
} 
