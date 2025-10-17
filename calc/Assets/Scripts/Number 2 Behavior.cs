using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Number2Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    public static int number2Value;
    public TextMeshProUGUI number2Text;

    void Start()
    {
        number2Value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        number2Text.text = number2Value.ToString();
    }
}
