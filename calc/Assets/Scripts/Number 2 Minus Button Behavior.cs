using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number2MinusButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public Button number2MinusButton;

    void Start()
    {
        number2MinusButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        if (Number2Behavior.number2Value > 0)
        {
            Number2Behavior.number2Value--;
        }
    }
}
