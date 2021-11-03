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
