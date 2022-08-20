using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine;


// CSV (Comma Separated Values) 파일은 데이터 목록이 포함 된 일반 텍스트 파일입니다.
// 이러한 파일은 서로 다른 응용 프로그램간에 데이터를 교환하는 데 자주 사용됩니다.
// 예를 들어 데이터베이스 및 연락처 관리자는 종종 CSV 파일을 지원합니다.
public class CSVParser
{

    // sPathName :  폴더가 Resources 하위 부터 시작해야 한다. "TableData/test" 
    public static List<string[]> Load(string sPathName)
    {
        List<string[]> listData = new List<string[]>();

        //TextAsset kTextAsset2 = Resources.Load(sPathName, typeof(TextAsset)) as TextAsset;
        //TextAsset kTextAsset3 = (TextAsset)Resources.Load(sPathName, typeof(TextAsset));
        TextAsset kTextAsset = Resources.Load<TextAsset>(sPathName);

        if (kTextAsset == null) 
            return null;

        StringReader _reader = new StringReader(kTextAsset.text);
        
            string inputData = _reader.ReadLine();
            while (inputData != null)
            {
                string[] datas = inputData.Split('\t');
                if (datas.Length == 0)
                    continue;

                listData.Add(datas);

                inputData = _reader.ReadLine();
            }
            _reader.Close();
        
        return listData;
    }


    // sPathName :  주의) 폴더가 Assets부터 시작해야 한다. "Assets/Resources/TableData/test.csv" 
    public static List<string[]> Load2(string sPathName)
    {
        List<string[]> listData = new List<string[]>();

        StreamReader sr = new StreamReader(sPathName, Encoding.UTF8);
        if (sr == null) return null;

        while (!sr.EndOfStream)                         // 스트림의 끝까지 읽기
        {
            string line = sr.ReadLine();                // 한 줄씩 읽어온다.
            
            string[] datas = line.Split('\t');           // 탭을 기준으로 문자를 분리한다.
            if (datas.Length == 0)
                continue;

            listData.Add(datas);
        }
        sr.Close();

        return listData;
    }


    // sPathName :  주의) 폴더가 Assets부터 시작해야 한다. "Assets/Resources/TableData/test.csv" 
    public static List<string[]> Load3(string sPathName)
    {
        List<string[]> listData = new List<string[]>();

        //StreamReader sr = new StreamReader(sPathName, Encoding.UTF8);
        //if (sr == null) return null;
        //string strAll = sr.ReadToEnd();
        //sr.Close();

        string strAll = File.ReadAllText(sPathName, Encoding.UTF8);

        StringReader _reader = new StringReader(strAll);

        string inputData = _reader.ReadLine();
        while (inputData != null)
        {
            string[] datas = inputData.Split('\t');
            if (datas.Length == 0)
                continue;

            listData.Add(datas);

            inputData = _reader.ReadLine();
        }
        _reader.Close();
        return listData;
    }



}
