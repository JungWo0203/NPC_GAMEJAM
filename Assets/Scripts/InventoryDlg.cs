using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDlg : MonoBehaviour
{
    public Button m_button_EnterOptions=null;
    public Button m_button_ExitOptions=null;
    public GameObject m_OptionPanel = null;
    //public Text LogText = null;
    // Start is called before the first frame update
    public void Initialize()
    {
        m_OptionPanel.SetActive(false);
        m_button_ExitOptions.gameObject.SetActive(false);
        m_button_EnterOptions.onClick.AddListener(OnOptionPress);
        m_button_ExitOptions.onClick.AddListener(OnOptionExit);
    }
    void OnOptionExit()
    {
        m_OptionPanel.SetActive(false);        
        m_button_ExitOptions.gameObject.SetActive(false);
    }
    void OnOptionPress()
    {
        m_OptionPanel.SetActive(true);
        m_button_ExitOptions.gameObject.SetActive(true);
        //LogText.text = TextMgr.Inst.m_assetTexts[GameMgr.Inst.ginfo.m_lastSelection-1].desc;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
