using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Number1Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    public static int number1Value;
    public TextMeshProUGUI number1Text;

    void Start()
    {
        number1Value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        number1Text.text = number1Value.ToString();
    }
}
