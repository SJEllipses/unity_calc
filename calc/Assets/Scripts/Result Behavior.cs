using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class ResultBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI equalsText;

    void Start()
    {
        resultText.text = 2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(OperatorChangeButtonBehavior.currentOperator == 0)
        {
            resultText.text = (Number1Behavior.number1Value + Number2Behavior.number2Value).ToString();
            equalsText.text = "=";
        }
        else if(OperatorChangeButtonBehavior.currentOperator == 1)
        {
            resultText.text = (Number1Behavior.number1Value - Number2Behavior.number2Value).ToString();
            equalsText.text = "=";
        }
        else if(OperatorChangeButtonBehavior.currentOperator == 2)
        {
            resultText.text = (Number1Behavior.number1Value * Number2Behavior.number2Value).ToString();
            equalsText.text = "=";
        }
        else if(OperatorChangeButtonBehavior.currentOperator == 3)
        {   
            if(Number2Behavior.number2Value == 0)
            {
                resultText.text = "?";
            }
            else
            {
                double resultValue = (double)Number1Behavior.number1Value / (double)Number2Behavior.number2Value;
                if (resultValue % 1 == 0)
                {
                    resultText.text = (Number1Behavior.number1Value / Number2Behavior.number2Value).ToString();
                    equalsText.text = "=";
                }
                else
                {
                    int roundedResultValue = (int)Math.Round(resultValue);
                    resultText.text = roundedResultValue.ToString();
                    equalsText.text = "¡Ö";
                }
            } 
        }
    }
}
