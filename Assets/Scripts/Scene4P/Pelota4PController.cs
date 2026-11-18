using System.Collections;
using UnityEngine;

public class Pelota4PController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float force;
    [SerializeField] GameManager4P manager;
    float MIN_Y = -1;
    float MAX_Y = 1;
    float MIN_ANGLE = -1;
    float MAX_ANGLE = 1;
    float delay = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        int dirX = Random.Range(0, 2) == 0 ? -1 : 1;
        int dirY = Random.Range(0, 2) == 0 ? -1 : 1;
        StartCoroutine(ThrowRandom(dirX, dirY));
    }

    IEnumerator ThrowRandom(int dirX, int dirY)
    {
        yield return new WaitForSeconds(delay);
        float posY = Random.Range(MIN_Y, MAX_Y);
        float angle = Random.Range(MIN_ANGLE, MAX_ANGLE);

        transform.position = new Vector3(0, posY, 0);
        angle *= Mathf.Deg2Rad;

        float x = Mathf.Cos(angle) * dirX;
        float y = Mathf.Cos(angle) * dirY;

        Vector2 impulse = new Vector2(x, y);
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(impulse * force, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Porteria1")
        {
            Debug.Log("Gol en porteria 1");
            manager.AddP1Score();
            StartCoroutine(ThrowRandom(1,-1));
        }
        if (collision.tag == "Porteria2")
        {
            Debug.Log("Gol en porteria 2");
            manager.AddP2Score();
            StartCoroutine(ThrowRandom(-1,-1));
        }
        if (collision.tag == "Porteria3")
        {
            Debug.Log("Gol en porteria 3");
            manager.AddP3Score();
            StartCoroutine(ThrowRandom(1,1));
        }
        if (collision.tag == "Porteria4")
        {
            Debug.Log("Gol en porteria 4");
            manager.AddP4Score();
            StartCoroutine(ThrowRandom(-1,1));
        }
    }
}

/*
            int y = Random.Range(0, 2) == 0 ? -1 : 1;
            StartCoroutine(ThrowRandom(-1,y));
*/