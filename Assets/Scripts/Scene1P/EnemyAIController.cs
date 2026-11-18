using UnityEngine;

public class EnemyAIController : MonoBehaviour
{
    [SerializeField] GameObject ball;
    const float maxY = 4.2f;
    const float minY = -4.2f;


    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < maxY || this.transform.position.y > minY)
        {
            float ballpos = ball.gameObject.transform.position.y;
            float x = this.transform.position.x;
            float y = ballpos;
            float z = this.transform.position.z;

            Debug.Log("Posicion x: " + x + " Posicion y: " + y + " Posicion z: " + z);

            this.transform.position = new Vector3(x, y, z);
        }

    }
}
