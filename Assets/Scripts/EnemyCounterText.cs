/////////////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/2/21
//// Proj: ProjectWorlds
//// Desc: Updates text to display the number of enemies left
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCounterText : MonoBehaviour
{

    public void UpdateText(int Left)
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = "Enemies Left: " + Left.ToString();
    }


}
