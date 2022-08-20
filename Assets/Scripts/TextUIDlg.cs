using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUIDlg : MonoBehaviour
{
    public Text m_textDesc;
    public Text m_selectionText_1;
    public Text m_selectionText_2;
    public Text m_selectionTextSingle;
    public int m_currentid = 0;
    public Button m_select1;
    public Button m_select2;
    public Button m_selectSingle;
    public EndingScript m_endingScript = null;

    public void Initialize()
    {
        m_select1.onClick.AddListener(OnClick_Select1);
        m_select2.onClick.AddListener(OnClick_Select2);
        m_selectSingle.onClick.AddListener(OnClick_Single);
        m_currentid = 1;
        DescTextChange();
    }

    public void Onclick_LogPanel()
    {
        string Log = TextMgr.Inst.m_assetTexts[m_currentid + 4].desc;
    }
    public void OnClick_Select1()
    {
        int connectedId = TextMgr.Inst.m_assetTexts[m_currentid].connectedid;
        if (TextMgr.Inst.m_assetTexts[m_currentid - 1].category==3)
        {
            m_endingScript.PrintEndingCredit(1);
            //비활성화
        }
        else
        {
            m_currentid = m_currentid + connectedId + 1;
            DescTextChange();
        }

    }
    public void OnClick_Select2()
    {
        int connectedId = TextMgr.Inst.m_assetTexts[m_currentid +1].connectedid;
        if(m_currentid == 3)
        {
            Mapae();
        }
        if (TextMgr.Inst.m_assetTexts[m_currentid - 1].category == 3)
        {
            m_endingScript.PrintEndingCredit(2);
            //비활성화
        }
        else
        {
            m_currentid = m_currentid + connectedId + 1;
            DescTextChange();
        }
    }
    public void Mapae()
    {

    }

    public void OnClick_Single()
    {
        int connectedId = TextMgr.Inst.m_assetTexts[m_currentid - 1].connectedid;
        m_currentid = m_currentid + connectedId;
        DescTextChange();
    }
    public void DescTextChange()
    {
        m_textDesc.text = TextMgr.Inst.m_assetTexts[m_currentid-1].desc;
        int selection_Num = TextMgr.Inst.m_assetTexts[m_currentid-1].selection;
        Debug.Log(selection_Num);
        if (selection_Num == 2)
        {
            m_selectionText_1.text = TextMgr.Inst.m_assetTexts[m_currentid].desc;
            m_selectionTextSingle.gameObject.SetActive(false);
            m_selectionText_1.gameObject.SetActive(true);
            m_selectionText_2.gameObject.SetActive(true);
            m_selectionText_1.text = TextMgr.Inst.m_assetTexts[m_currentid].desc;
            m_selectionText_2.text = TextMgr.Inst.m_assetTexts[m_currentid + 1].desc;
            GameMgr.Inst.ginfo.m_lastSelection = m_currentid;
        }
        else if (selection_Num == 1)
        {
            m_selectionText_1.gameObject.SetActive(false);
            m_selectionText_2.gameObject.SetActive(false);
            m_selectionTextSingle.gameObject.SetActive(true);
            m_selectionTextSingle.text = "계속";
            GameMgr.Inst.ginfo.m_lastSelection = m_currentid;
        }
        else if (selection_Num == 3)
        {

        }
        else if (selection_Num == 4)
        {
            m_selectionText_1.gameObject.SetActive(false);
            m_selectionText_2.gameObject.SetActive(false);
            m_selectionTextSingle.gameObject.SetActive(true);
            m_selectionTextSingle.text = "죽었습니다.";
            m_selectionTextSingle.gameObject.transform.localScale = Vector3.one * 2;
            m_selectSingle.interactable = false;
            GameMgr.Inst.ginfo.m_lastSelection = m_currentid;
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
