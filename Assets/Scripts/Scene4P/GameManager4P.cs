using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager4P : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI p1scoreTXT;
    [SerializeField] TextMeshProUGUI p2scoreTXT;
    [SerializeField] TextMeshProUGUI p3scoreTXT;
    [SerializeField] TextMeshProUGUI p4scoreTXT;
    [SerializeField] GameObject pelota;
    bool running = false;
    int p1score = 0;
    int p2score = 0;
    int p3score = 0;
    int p4score = 0;

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

    public void AddP3Score()
    {
        p3score++;
        p3scoreTXT.text = p3score.ToString();
    }

    public void AddP4Score()
    {
        p4score++;
        p4scoreTXT.text = p4score.ToString();
    }
}
