using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number1MinusButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public Button number1MinusButton;

    void Start()
    {
        number1MinusButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        if (Number1Behavior.number1Value > 0)
        {
            Number1Behavior.number1Value--;
        }
    }
}
