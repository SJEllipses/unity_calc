using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperatorChangeButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    // + => 0
    // - => 1
    // * => 2
    // / => 3
    public static string[] operatorTexts = {"+", "-", "¡Á", "¡Â"};
    public static int currentOperator;

    public Button operatorChangeButton;

    void Start()
    {
        operatorChangeButton.onClick.AddListener(OnButtonClick);
        currentOperator = 0;
    }

    void OnButtonClick()
    {
        if(currentOperator == 3)
        {
            currentOperator = 0;
        }
        else
        {
            currentOperator++;
        }
    }
}
