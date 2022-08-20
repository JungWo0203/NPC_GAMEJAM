using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDlg : MonoBehaviour
{
    public Button m_button_EnterLog=null;
    public Button m_button_ExitLog=null;
    public GameObject m_LogPanel = null;
    public Text LogText = null;
    // Start is called before the first frame update
    public void Initialize()
    {
        m_LogPanel.SetActive(false);
        m_button_ExitLog.gameObject.SetActive(false);
        m_button_EnterLog.onClick.AddListener(OnLogPress);
        m_button_ExitLog.onClick.AddListener(OnLogExit);
    }
    void OnLogExit()
    {
        m_LogPanel.SetActive(false);        
        m_button_ExitLog.gameObject.SetActive(false);
    }
    void OnLogPress()
    {
        m_LogPanel.SetActive(true);
        m_button_ExitLog.gameObject.SetActive(true);
        LogText.text = TextMgr.Inst.m_assetTexts[GameMgr.Inst.ginfo.m_lastSelection-1].desc;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
