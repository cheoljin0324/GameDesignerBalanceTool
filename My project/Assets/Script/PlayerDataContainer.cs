using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataContainer : MonoBehaviour
{
    [Header("ĳ���� �̸�")]
    public string chName;
    [Header("ü��")]
    public float hp;
    [Header("���ݷ�")]
    public int atk;
    [Header("����")]
    public int def;
    [Header("�� ����")]
    public int bdef;
    [Header("����")]
    public float atkspd;
    [Header("�̵��ӵ�")]
    public float walkspd;
    [Header("���� ����")]
    public float atkScale;
    [Header("�����ɷ�")]
    public float bdrain;
    [Header("��� ����")]
    public string weapown;
    [Header("��� ��")]
    public string shiled;
    [Header("����ġ")]
    public float exp;
    [Header("����")]
    public int lv;

    public void DataSet()
    {
        FindObjectOfType<DataSetting>().useData(chName, hp, atk, def, bdef, atkspd, walkspd, atkScale, bdrain, weapown, shiled, exp, lv);
    }
}
