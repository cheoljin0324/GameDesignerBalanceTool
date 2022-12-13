using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestManager : MonoBehaviour
{
    public Stats Player;
    public WeapownSetting wSetting;
    public ShildSo shiled;
    public CharacterMemory chmemory;
    public List<Stats> setList;

    [SerializeField]
    GameObject setContent;

    [SerializeField]
    GameObject profilePrefab;

    public Text tName;
    public Text tHp;
    public Text tAtk;
    public Text tDef;
    public Text tBdef;
    public Text tAtkSpd;
    public Text tSpd;
    public Text tAtkRange;
    public Text tBld;
    public Text tWep;
    public Text tShield;
    public Text tExp;
    public Text tLv;

    public void TestAdd(int set)
    {
        if (FindObjectOfType<GameManager>().isTestRoom)
        {
            if (Player.chName == "")
            {
                Player = chmemory.chList[set];
                UpdatePlayer();
            }
            else
            {
                setList.Add(chmemory.chList[set]);
                UpdateEnemy();
            }
        }
    }

    public void UpdatePlayer()
    {
        wepownStats nowWeapown = new wepownStats();
        ShildDataSO shieldData = new ShildDataSO();

        for(int i = 0; i<wSetting.wepownStats.Count; i++)
        {
            if(wSetting.wepownStats[i].Wname == Player.weapown)
            {
                nowWeapown = wSetting.wepownStats[i];
            }
        }

        for (int i = 0; i < shiled.shildSOs.Count; i++)
        {
            if (shiled.shildSOs[i].name == Player.shiled)
            {
                shieldData = shiled.shildSOs[i];
            }
        }


        tName.text = Player.chName;
        tHp.text = "Ã¼·Â :" + (Player.hp + nowWeapown.hp + shieldData.hp).ToString();
        tAtk.text = "ATK :" + (Player.atk + nowWeapown.atk + shieldData.atk).ToString();
        tDef.text = "DEF :" + (Player.def + nowWeapown.def + shieldData.def).ToString();
        tBdef.text = "B-DEF :" + (Player.bdef + nowWeapown.bdef + shieldData.bdef).ToString();
        tAtkSpd.text = "ATK_SPD :" + (Player.atkspd + nowWeapown.atkTime + shieldData.aktspd).ToString();
        tSpd.text = "SPD :" + (Player.walkspd + nowWeapown.spd + shieldData.spd).ToString();
        tAtkRange.text = "ATK_RANGE :" + (Player.atkScale + nowWeapown.atkRange + shieldData.atkRange).ToString();
        tBld.text = "BLD :" + (Player.bdrain + nowWeapown.blode + shieldData.blode).ToString();
        tWep.text = "WEP :" + Player.weapown;
        tShield.text = "WEP :" + Player.shiled;
        tExp.text = "EXP :" + Player.exp.ToString();
        tLv.text = "LV :" + Player.lv.ToString();
    }

    public void CLSPlayer()
    {
        Player = new Stats();

    }

    public void UpdateEnemy()
    {
        GameObject set = Instantiate(profilePrefab);
        set.transform.parent = setContent.transform;
        set.GetComponentInChildren<Text>().text = setList[setList.Count].chName;
    }

    public void CLSEnemy()
    {
        setList.Clear();
        for(int i = 0; i< setContent.GetComponentsInChildren<Transform>().Length; i++)
        {
            Destroy(setContent.GetComponentsInChildren<Transform>()[i].gameObject);
        }
    }
}
