using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    List<string> New = new List<string>();
    public bool isTestRoom;
    public int buttonIndex = 0;
    [SerializeField]
    public GameObject useSimulatorText;
    [SerializeField]
    public GameManager scrollContentSimul;

    // Start is called before the first frame update
    void Start()
    {
        List<Dictionary<string, object>> dataList = CSVReader.Read("TestPractice2");
        for (int i = 0; i<dataList.Count; i++)
        {
            New.Add(dataList[i]["new"].ToString());
        }

        for(int i = 0; i<New.Count; i++)
        {
            Debug.Log(New[i]);
        }

    }
}
