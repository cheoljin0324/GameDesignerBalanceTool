using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simulator : MonoBehaviour
{
    public Stats useStats;
    public List<Simulator> Target;
    GameManager useFind;


    public IEnumerator SimulatorOn()
    {
        while (Target.Count != 0)
        {
            if (useFind == null)
            {
                useFind = FindObjectOfType<GameManager>();
            }
            yield return new WaitForSeconds(1 * useStats.atkspd);
            if (useStats.atkScale < Target.Count)
            {
                for (int i = 0; i < useStats.atkScale; i++)
                {
                    Target[i].useStats.hp -= useStats.atk - (Target[i].useStats.def + Target[i].useStats.bdef);
                    madeText(Target[i], useStats.atk - (Target[i].useStats.def + Target[i].useStats.bdef));
                    if (Target[i].useStats.hp < 0)
                    {
                        Death(Target[i]);
                        Target.RemoveAt(i);
                        StopCoroutine("SimulatorOn");
                    }
                }
            }
            else
            {

                for (int i = 0; i < useStats.atkScale; i++)
                {
                    Target[i].useStats.hp -= useStats.atk - (Target[i].useStats.def + Target[i].useStats.bdef);
                    madeText(Target[i], useStats.atk - (Target[i].useStats.def + Target[i].useStats.bdef));
                    if (Target[i].useStats.hp < 0)
                    {
                        Death(Target[i]);
                        Target.RemoveAt(i);
                        StopCoroutine("SimulatorOn");
                    }
                }
            }
        }
    }

    public void madeText(Simulator target,int damage)
    {
        GameObject useText = Instantiate(useFind.useSimulatorText);
        useText.transform.SetAsFirstSibling();
        useText.transform.localScale = new Vector3(1, 1, 1);
        useText.GetComponent<Text>().text = target.useStats.chName + "에게" + damage + "를 가했습니다";  
    }

    public void Death(Simulator target)
    {
        GameObject useText = Instantiate(useFind.useSimulatorText);
        useText.transform.SetAsFirstSibling();
        useText.transform.localScale = new Vector3(1, 1, 1);
        useText.GetComponent<Text>().text = target.useStats.chName + "이 사망했습니다";
    }
}
