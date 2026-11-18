using UnityEngine;

public class PalaController : MonoBehaviour
{
    [SerializeField] float speed = 3.5f;
    const float maxY = 4.2f;
    const float minY = -4.2f;

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("Pala2"))
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxY)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minY)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }

        if (CompareTag("Pala1"))
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y < maxY)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > minY)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
}
