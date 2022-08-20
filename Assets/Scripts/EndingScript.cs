using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScript : MonoBehaviour
{
    public Text m_endingText = null;
    public GameObject m_blackScreen = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PrintEndingCredit(int kint)
    {
        m_blackScreen.SetActive(true);
        StartCoroutine(EndingCredit(kint));
    }
    IEnumerator EndingCredit(int bint)
    {
        if(bint == 1)
        {
            m_endingText.text = "�̼����� ����� �����Ͽ����� �״� �׳����� �츮������ �ػ� �Լ��� ������� �е����� ������ �̷��ϼ̽��ϴ�. ���ó��� ���ƿ� ����� ���翡�� �ڽ��� ������ ���� �˾� ���� �� �ֽ��ϴ�.";
        }
        else
        {
            m_endingText.text = "�̼����� �̹� ����ӿ����� ����Ͽ����ϴ�. �׷��� �״� �� �������� ����� �¼� �ο�ٰ� �����ϼ̽��ϴ�. ���ó��� ���ƿ� ����� �ƹ��� ��ȭ���� ������ �ٽ� �����ϰ� �˴ϴ�.";
        }
        for (int i = 0; i < 1;)
        {
            m_endingText.gameObject.transform.localPosition -= new Vector3(0,10,0);
            if (m_endingText.gameObject.transform.localPosition.y <= -800)
            {
                i++;
            }
        }
        yield return new WaitForSeconds(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
