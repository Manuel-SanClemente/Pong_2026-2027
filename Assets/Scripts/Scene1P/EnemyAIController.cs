using UnityEngine;

public class EnemyAIController : MonoBehaviour
{
    [SerializeField] GameObject ball;
    const float maxY = 4.2f;
    const float minY = -4.2f;


    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y < maxY || ball.transform.position.y > minY)
        {
            float ballpos = ball.transform.position.y;
            Vector3 initialpos = this.transform.position;
            Vector3 targetpos = new Vector3(initialpos.x, ballpos, initialpos.z);

            this.transform.position = Vector3.Lerp(initialpos, targetpos, Time.deltaTime);
        }

    }
}
