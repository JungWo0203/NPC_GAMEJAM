using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LobbySceneDlg : MonoBehaviour
{
    public static string Nickname = null;
    public InputField m_iField_nickname = null;
    public Button m_button_start = null;

    void Start()
    {
        m_button_start.onClick.AddListener(LoadGameScene);
        
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
        Nickname = m_iField_nickname.text;
        Debug.Log(Nickname);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
