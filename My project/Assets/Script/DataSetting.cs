using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataSetting : MonoBehaviour
{
    public CharacterMemory soBase;

    [Header("이름")]
    [SerializeField]
    InputField chName;
    [Header("체력")]
    [SerializeField]
    InputField hp;
    [Header("공격력")]
    [SerializeField]
    InputField atk;
    [Header("방어력")]
    [SerializeField]
    InputField def;
    [Header("피방어력")]
    [SerializeField]
    InputField bdef;
    [Header("공격 속도")]
    [SerializeField]
    InputField atkspd;
    [Header("이동 속도")]
    [SerializeField]
    InputField walkSpd;
    [Header("공격 범위")]
    [SerializeField]
    InputField atkRange;
    [Header("흡혈")]
    [SerializeField]
    InputField blod;
    [Header("사용 무기")]
    [SerializeField]
    InputField weapown;
    [Header("경험치")]
    [SerializeField]
    InputField exp;
    [Header("레벨")]
    [SerializeField]
    InputField lv;

    public void add()
    {
        Stats newstat = new Stats();
        newstat.chName = chName.text;
        newstat.hp = float.Parse(hp.text);
        newstat.atk = int.Parse(atk.text);
        newstat.def = int.Parse(def.text);
        newstat.bdef = int.Parse(bdef.text);
        newstat.atkspd = float.Parse(atkspd.text);
        newstat.walkspd = float.Parse(walkSpd.text);
        newstat.atkScale = float.Parse(atkRange.text);
        newstat.bdrain = float.Parse(blod.text);
        newstat.weapown = weapown.text;
        newstat.exp = float.Parse(exp.text);
        newstat.lv = int.Parse(lv.text);

        soBase.chList.Add(newstat);

        chName.text = "";
        hp.text = "";
        atk.text = "";
        def.text = "";
        bdef.text = "";
        atkspd.text = "";
        walkSpd.text = "";
        atkRange.text = "";
        blod.text = "";
        weapown.text = "";
        exp.text = "";
        lv.text = "";
    }
}
