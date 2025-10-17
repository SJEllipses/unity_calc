using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OperatorBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI operatorText;

    void Start()
    {
        operatorText.text = "+";
    }

    // Update is called once per frame
    void Update()
    {
        operatorText.text = OperatorChangeButtonBehavior.operatorTexts[OperatorChangeButtonBehavior.currentOperator];
    }
}
