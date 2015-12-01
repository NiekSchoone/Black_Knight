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

    private Collider2D myCollider;

    void Start()
    {
        //get random values for a diverse bounce effect
        bounceSpeedX = Random.Range(1.5f, 2.5f);
        bounceSpeedY = Random.Range(0.5f, 1.5f);
        bounceHeight = Random.Range(1.5f, 2.5f);
        bounceAmount = Random.Range(1, 3);

        startTime = Time.time;

        //dissable my collider so i wont be picked up prematurely
        myCollider = GetComponent<Collider2D>();
        myCollider.enabled = false;

        localPos = new Vector2(transform.position.x, transform.position.y);

        StartCoroutine(Bounce());
    }

    IEnumerator Bounce()
    {
        //bounce an amount of times for each given bounceAmount
        for (int i = 0; i < bounceAmount; i++)
        {
            bounceTime = 0;

            //as long as i havent counted to 1 yet, keep the curve going
            while (bounceTime < 1)
            {
                //Get the time since the coroutine started
                float localTime = Time.time - startTime;

                bounceTime += Time.deltaTime * bounceSpeedY;
                transform.position = new Vector2(localPos.x + bounceSpeedX * localTime, localPos.y + BounceMath(bounceTime) * bounceHeight);
                yield return null;
            }
            //decrease the bounce height after each bounce by 1 so i dont bounce as high as the previous bounce
            bounceHeight--;
        }
        //enable my collider to be picked up
        myCollider.enabled = true;
    }

    //return a sine wave
    float BounceMath(float time)
    {
        return Mathf.Sin(Mathf.Clamp01(time) * Mathf.PI);
    }
} 
