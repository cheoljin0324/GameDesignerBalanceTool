using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterSOArr", menuName = "ScriptableObject/CharacterSOArr")]
public class CharacterMemory : ScriptableObject
{
    public List<Stats> chList;
}

[System.Serializable]
public struct Stats
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
}
