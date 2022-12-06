using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataSetting : MonoBehaviour
{
    public CharacterMemory soBase;
    CharacterButtonSet cbtset;

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
    [Header("��� ��")]
    [SerializeField]
    InputField shiled;
    [Header("����ġ")]
    [SerializeField]
    InputField exp;
    [Header("����")]
    [SerializeField]
    InputField lv;

    [Header("�̸�")]
    [SerializeField]
    Text TName;
    [Header("ü��")]
    [SerializeField]
    Text Thp;
    [Header("���ݷ�")]
    [SerializeField]
    Text Tatk;
    [Header("����")]
    [SerializeField]
    Text Tdef;
    [Header("�ǹ���")]
    [SerializeField]
    Text Tbdef;
    [Header("���� �ӵ�")]
    [SerializeField]
    Text Tatkspd;
    [Header("�̵� �ӵ�")]
    [SerializeField]
    Text TwalkSpd;
    [Header("���� ����")]
    [SerializeField]
    Text TatkRange;
    [Header("����")]
    [SerializeField]
    Text Tblod;
    [Header("��� ����")]
    [SerializeField]
    Text Tweapown;
    [Header("��� ��")]
    [SerializeField]
    Text Tshiled;
    [Header("����ġ")]
    [SerializeField]
    Text Texp;
    [Header("����")]
    [SerializeField]
    Text Tlv;


    private void Start()
    {
        cbtset = GetComponent<CharacterButtonSet>();
    }

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
        newstat.shiled = shiled.text;
        newstat.exp = float.Parse(exp.text);
        newstat.lv = int.Parse(lv.text);

        soBase.chList.Add(newstat);
        cbtset.CharacterSet();

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
        shiled.text = "";
        exp.text = "";
        lv.text = "";
    }

    public void useData(string chName, float hp, int atk, int def, int bdef, float atkspd, float walkspd, float atkScale, float bdrain, string weapown, string shiled, float exp, int lv)
    {
        this.chName.text = chName;
        this.hp.text = hp.ToString();
        this.atk.text = atk.ToString();
        this.def.text = def.ToString();
        this.bdef.text = bdef.ToString();
        this.atkspd.text = atkspd.ToString();
        this.walkSpd.text = walkspd.ToString();
        this.atkRange.text = atkScale.ToString();
        this.blod.text = bdrain.ToString();
        this.weapown.text = weapown;
        this.shiled.text = shiled;
        this.exp.text = exp.ToString();
        this.lv.text = lv.ToString();
        TName.text = "�̸� :" + chName;
        Thp.text = "ü�� :" + hp.ToString();
        Tatk.text = "ATK :" + atk.ToString();
        Tdef.text = "DEF :" + def.ToString();
        Tbdef.text = "B-DEF :" + bdef.ToString();
        Tatkspd.text = "ATK_SPD :" + atkspd.ToString()+"%";
        TwalkSpd.text = "SPD :" + walkSpd.ToString() + "%";
        TatkRange.text = "ATK_RANGE :" + atkRange.ToString() + "%";
        Tblod.text = "BLD :" + blod.ToString() + "%";
        Tweapown.text = "WEP :" + weapown;
        Tshiled.text = "SHD :" + shiled;
        Texp.text = "EXP :" + exp.ToString();
        Tlv.text = "LV :" + lv.ToString();
    }

    public void WepownSet(string ItemId)
    {
        weapown.text = ItemId;
    }

    public void ShiledSet(string ItemID)
    {
        shiled.text = ItemID;
    }
}
