using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
using System.Text;
public class SaveInfo
{

    public int lastSelectionId=0;
    public string m_nickname="";

    public void SaveFile()
    {

        FileStream fs = new FileStream("saveinfo.data", FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write(lastSelectionId);
        bw.Write(m_nickname);
        bw.Close();
        fs.Close();
    }
    public void LoadFile()
    {
        try
        {
            FileStream fs = new FileStream("saveinfo.data", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            lastSelectionId = br.ReadInt32();
            m_nickname = br.ReadString();
            br.Close();
            fs.Close();
            GameMgr.Inst.ginfo.m_lastSelection = lastSelectionId;
            GameMgr.Inst.ginfo.m_nickname = m_nickname;
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
    }

}


