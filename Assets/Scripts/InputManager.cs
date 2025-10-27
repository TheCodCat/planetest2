using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [SerializeField] private AudioSource AudioSource;
    private Button[] buttons;
    public void ChangeSceneName(string name)
    {
        StartCoroutine(Loader(name));
    }

    private IEnumerator Loader(string name)
    {
        SceneManager.LoadSceneAsync(name);
        yield return null;
    }
    private void Start()
    {
        buttons = GameObject.FindObjectsByType<Button>(FindObjectsSortMode.None);
        Debug.Log(buttons.Length);
        foreach (var item in buttons)
        {
            item.onClick.AddListener(Click);
        }
    }

    private void OnDisable()
    {
        foreach (var item in buttons)
        {
            item.onClick.RemoveListener(Click);
        }
    }

    public void Click()
    {
        AudioSource.Play();
        
    }

    
}
