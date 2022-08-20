using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{

    [HideInInspector] public BattleFSM m_battleFSM = new BattleFSM();
    public TextUIDlg m_textUIDlg = null;
    private void Awake()
    {
        GameMgr.Inst.Initialize();
        GameMgr.Inst.gameScene = this;
        GameMgr.Inst.sinfo.LoadFile();
    }
    private void OnApplicationQuit()
    {
        GameMgr.Inst.sinfo.SaveFile();
    }
    private void Start()
    {
        m_battleFSM.Initialize(CB_Ready, CB_Wave, CB_Game, CB_Result);
        GameMgr.Inst.gameScene.m_battleFSM.SetReadyState();
    }
    void CB_Ready()
    {
        GameMgr.Inst.gameScene.m_battleFSM.SetGameState();
    }
    void CB_Wave()
    {

    }
    void CB_Game()
    {
        TextMgr.Inst.Initialize_Texts("TableData/lines");
        m_textUIDlg.Initialize();
    }
    void CB_Result()
    {

    }
    private void Update()
    {
        m_battleFSM.OnUpdate();
    }
}
