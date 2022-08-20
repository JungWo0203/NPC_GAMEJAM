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
            m_endingText.text = "이순신은 역사속 생존하였으며 죽는 그날까지 우리나라의 해상 함선의 기술력의 압도적인 도약을 이룩하셨습니다. 오늘날로 돌아온 당신은 역사에서 자신의 흔적을 조금 알아 차릴 수 있습니다.";
        }
        else
        {
            m_endingText.text = "이순신은 이번 역사속에서도 사망하였습니다. 그러나 죽는 그 순간까지 적들과 맞서 싸우다가 전사하셨습니다. 오늘날로 돌아온 당신은 아무런 변화없는 현실을 다시 마주하게 됩니다.";
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
