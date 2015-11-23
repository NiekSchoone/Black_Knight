using UnityEngine;
using System.Collections;

public class CoinBounce : MonoBehaviour
{
    private float bounceSpeedY;
    private float bounceSpeedX;
    private float bounceHeight;
    private float bounceAmount;
    private float bounceTime;

    private float startTime;

    void Start()
    {
        bounceSpeedX = Random.Range(1.5f, 2.5f);
        bounceSpeedY = Random.Range(0.5f, 1.5f);
        bounceHeight = Random.Range(1.5f, 2.5f);
        bounceAmount = Random.Range(1.5f, 2.5f); ;

        startTime = Time.time;

        StartCoroutine(Bounce());
    }

    IEnumerator Bounce()
    {
        for (int i = 0; i < bounceAmount; i++)
        {

            bounceTime = 0;
            while (bounceTime < 1)
            {
                float localTime = Time.time - startTime;
                bounceTime += Time.deltaTime * bounceSpeedY;
                transform.position = new Vector2(bounceSpeedX * localTime, BounceMath(bounceTime) * bounceHeight);
                yield return null;
            }
            bounceHeight--;
        }
    }

    float BounceMath(float t)
    {
        return Mathf.Sin(Mathf.Clamp01(t) * Mathf.PI);
    }
}
