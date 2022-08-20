using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetText
{
    public int id;
    public int selection;
    public int category;
    public int condition;
    public int connectedid;
    public string desc;

}
public class TextMgr
{
    static TextMgr _inst = null;
    public static TextMgr Inst
    {
        get
        {
            if (_inst == null)
            {
                _inst = new TextMgr();
            }
            return _inst;
        }
    }
    public List <AssetText> m_assetTexts = new List<AssetText> ();
    public void Initialize_Texts(string m_tabledata)
    {
        List<string[]> datalist = CSVParser.Load(m_tabledata);
        for(int i=1; i<datalist.Count; i++)
        {
            string[] data = datalist[i];
            AssetText assetText = new AssetText();
            assetText.id = int.Parse(data[0]);
            assetText.selection = int.Parse(data[1]);
            assetText.category = int.Parse(data[2]);
            assetText.condition = int.Parse(data[3]);
            assetText.connectedid = int.Parse(data[4]);
            assetText.desc = data[5];
            m_assetTexts.Add(assetText);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
