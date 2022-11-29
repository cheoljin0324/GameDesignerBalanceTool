using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataSetting : MonoBehaviour
{
    public CharacterMemory soBase;

    [Header("�̸�")]
    [SerializeField]
    InputField chName;
    [Header("ü��")]
    [SerializeField]
    InputField hp;
    [Header("���ݷ�")]
    [SerializeField]
    InputField atk;
    [Header("����")]
    [SerializeField]
    InputField def;
    [Header("�ǹ���")]
    [SerializeField]
    InputField bdef;
    [Header("���� �ӵ�")]
    [SerializeField]
    InputField atkspd;
    [Header("�̵� �ӵ�")]
    [SerializeField]
    InputField walkSpd;
    [Header("���� ����")]
    [SerializeField]
    InputField atkRange;
    [Header("����")]
    [SerializeField]
    InputField blod;
    [Header("��� ����")]
    [SerializeField]
    InputField weapown;
    [Header("����ġ")]
    [SerializeField]
    InputField exp;
    [Header("����")]
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
