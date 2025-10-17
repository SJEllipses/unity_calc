using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Number1PlusButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public Button number1PlusButton;

    void Start()
    {
        number1PlusButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        if(Number1Behavior.number1Value < 99)
        {
            Number1Behavior.number1Value++;
        }
    }
}
