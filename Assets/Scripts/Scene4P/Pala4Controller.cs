using UnityEngine;

public class Pala4Controller : MonoBehaviour
{
    [SerializeField] float speed = 3.5f;

    const float maxTopY = 4.2f;
    const float minTopY = 1.0f;

    const float maxBottomY = -1.0f;
    const float minBottomY = -4.2f;

    const float minLeftX = -9.0f;
    const float maxLeftX = -1.0f;

    const float minRightX = 1.0f;
    const float maxRightX = 9.0f;

    void Update()
    {
        if (CompareTag("Pala1"))
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y < maxTopY)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > minTopY)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A) && transform.position.x > minLeftX)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < maxLeftX)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }

        if (CompareTag("Pala2"))
        {
            if (Input.GetKey(KeyCode.T) && transform.position.y < maxTopY)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.G) && transform.position.y > minTopY)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.F) && transform.position.x > minRightX)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.H) && transform.position.x < maxRightX)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }

        if (CompareTag("Pala3"))
        {
            if (Input.GetKey(KeyCode.I) && transform.position.y < maxBottomY)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.K) && transform.position.y > minBottomY)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.J) && transform.position.x > minLeftX)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.L) && transform.position.x < maxLeftX)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }

        if (CompareTag("Pala4"))
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxBottomY)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minBottomY)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > minRightX)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < maxRightX)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
    }
}
