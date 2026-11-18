using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] Button button2p;
    [SerializeField] Button button4p;

    void Start()
    {
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

    void ChangeTo2Scene()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Scene change 2 button click");        
    }

    void ChangeTo4Scene()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Scene change 4 button click");        
    }
}
