using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVReadManager : MonoBehaviour
{
    List<Dictionary<string, object>> chData = new List<Dictionary<string, object>>();
    List<Dictionary<string, object>> wepownData = new List<Dictionary<string, object>>();
    List<Dictionary<string, object>> ShiledData = new List<Dictionary<string, object>>();
    List<Dictionary<string, object>> skillData = new List<Dictionary<string, object>>();

    [SerializeField]
    CharacterMemory chMemory;
    [SerializeField]
    ShildSo shiledSo;
    [SerializeField]
    WeapownSetting weapownSetting;

    private void Start()
    {
        chData = CSVReader.Read("characterSheet");
        wepownData = CSVReader.Read("wepownDataSheet");
        ShiledData = CSVReader.Read("ShiledDataSheet");
        skillData = CSVReader.Read("skillDataSheed");


    }

    void DataSetting()
    {
        chMemory.chList.Clear();
        shiledSo.shildSOs.Clear();
        weapownSetting.wepownStats.Clear();

        for(int i = 0; i<chData.Count; i++)
        {
            Stats currentstat = new Stats();
            currentstat.chName = chData[i]["atk"].ToString();
            currentstat.hp = int.Parse(chData[i]["hp"].ToString());
            currentstat.atk = int.Parse(chData[i]["atk"].ToString());
            currentstat.def = int.Parse(chData[i]["def"].ToString());
            currentstat.bdef = int.Parse(chData[i]["bdef"].ToString());
            currentstat.atkspd = float.Parse(chData[i]["atkSpd"].ToString());
            currentstat.walkspd = float.Parse(chData[i]["walkSpd"].ToString());
            currentstat.bdrain = float.Parse(chData[i]["bdrain"].ToString());
            currentstat.weapown = chData[i]["wepown"].ToString();
            currentstat.shiled = chData[i]["shiled"].ToString();
            currentstat.exp = float.Parse(chData[i]["exp"].ToString());
            currentstat.lv = int.Parse(chData[i]["lv"].ToString());
        }

        for(int i = 0; i<wepownData.Count; i++)
        {
            wepownStats currentstat = new wepownStats();
            currentstat.Wname = wepownData[i]["atk"].ToString();
            currentstat.hp = int.Parse(wepownData[i]["hp"].ToString());
            currentstat.atk = int.Parse(wepownData[i]["atk"].ToString());
            currentstat.def = int.Parse(wepownData[i]["def"].ToString());
            currentstat.bdef = int.Parse(wepownData[i]["bdef"].ToString());
            currentstat.aktspd = float.Parse(wepownData[i]["atkSpd"].ToString());
            currentstat.spd = float.Parse(wepownData[i]["walkSpd"].ToString());
            currentstat.blode = float.Parse(wepownData[i]["bdrain"].ToString());
            currentstat.atkRange = float.Parse(wepownData[i]["atkRange"].ToString());
            currentstat.Range = float.Parse(wepownData[i]["Range"].ToString());
            currentstat.atkTime = float.Parse(wepownData[i]["atkTime"].ToString());
            currentstat.categori = wepownData[i]["type"].ToString() == "Almost" ? weapownCategori.Almost : weapownCategori.far;
        }

        for(int i = 0; i<ShiledData.Count; i++)
        {
            ShildDataSO currentstat = new ShildDataSO();
            currentstat.hp = int.Parse(ShiledData[i]["hp"].ToString());
            currentstat.atk = int.Parse(ShiledData[i]["atk"].ToString());
            currentstat.def = int.Parse(ShiledData[i]["def"].ToString());
            currentstat.bdef = int.Parse(ShiledData[i]["bdef"].ToString());
            currentstat.aktspd = float.Parse(ShiledData[i]["atkSpd"].ToString());
            currentstat.spd = float.Parse(ShiledData[i]["walkSpd"].ToString());
            currentstat.blode = float.Parse(ShiledData[i]["bdrain"].ToString());
        }
    }
}
