using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number2PlusButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public Button number2PlusButton;

    void Start()
    {
        number2PlusButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        if (Number2Behavior.number2Value < 99)
        {
            Number2Behavior.number2Value++;
        }
    }
}
