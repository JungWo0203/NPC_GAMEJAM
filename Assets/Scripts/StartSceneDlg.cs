using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneDlg : MonoBehaviour
{

    // Start is called before the first frame update
    public void LoadGameScene()
    {
        SceneManager.LoadScene("LobbyScene");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary)
            {
                LoadGameScene();
            }
        }
    }
}
