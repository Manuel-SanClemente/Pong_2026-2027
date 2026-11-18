using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI p1scoreTXT;
    [SerializeField] TextMeshProUGUI p2scoreTXT;
    [SerializeField] GameObject pelota;
    bool running = false;
    int p1score = 0;
    int p2score = 0;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if (!running && Input.GetKeyDown(KeyCode.Space))
        {
            pelota.SetActive(true);
            running = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void AddP1Score()
    {
        p1score++;
        p1scoreTXT.text = p1score.ToString();
    }

    public void AddP2Score()
    {
        p2score++;
        p2scoreTXT.text = p2score.ToString();
    }
}
