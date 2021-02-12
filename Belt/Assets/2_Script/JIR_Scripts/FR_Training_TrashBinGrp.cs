using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FR_Training_TrashBinGrp : MonoBehaviour
{

    List<string> stringList = new List<string>();

    public List<Text> textList = new List<Text>();

    private void Awake()
    {
        stringList.Add("métal");
        stringList.Add("Plastique");
        stringList.Add("Verre");
        stringList.Add("Paper");

        stringList = ShuffleList(stringList);

        textList[0].text = stringList[0];
        textList[1].text = stringList[1];
        textList[2].text = stringList[2];
        textList[3].text = stringList[3];
    }

    public static List<string> ShuffleList(List<string> _list)
    {
        //items 리스트의 수만큼
        for (int i = 0; i < _list.Count; i++)
        {
            string temp = _list[i];
            int randomIndex = Random.Range(0, _list.Count);
            _list[i] = _list[randomIndex];
            _list[randomIndex] = temp;
        }
        return _list;
    }

}
