using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] Button button1p;
    [SerializeField] Button button2p;
    [SerializeField] Button button4p;

    void Start()
    {
        button1p.onClick.AddListener(ChangeTo1Scene);
        button2p.onClick.AddListener(ChangeTo2Scene);
        button4p.onClick.AddListener(ChangeTo4Scene);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void ChangeTo1Scene()
    {
        SceneManager.LoadScene(1);
    }

    void ChangeTo2Scene()
    {
        SceneManager.LoadScene(2);
    }

    void ChangeTo4Scene()
    {
        SceneManager.LoadScene(3);
    }
}
