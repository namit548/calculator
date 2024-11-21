using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class experimentalScript: MonoBehaviour
{
    public InputField display;
    public int previous = 0, current = 0, function = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per fame
    void Update()
    {

    }

    public void Store(int value)
    {
        // Append digits to the display text
        display.text = display.text+ value.ToString();
        current = int.Parse(display.text);
    }

    public void Sum()
    {
        previous = int.Parse(display.text);
        display.text = "";
        function = 1;
    }

    public void Sub()
    {
        previous = int.Parse(display.text);
        display.text = "";
        function = 2;
    }

    public void Mul()
    {
        previous = int.Parse(display.text);
        display.text = "";
        function = 3;
    }

    public void Div()
    {
        previous = int.Parse(display.text);
        display.text = "";
        function = 4;
    }

    public void clear()
    {
        display.text = "";
        previous = 0;
        current = 0;
        function = 0;
    }

    public void Cal()
    {
        if (function == 1)
        {
            display.text = (previous + current).ToString();
        }
        else if (function == 2)
        {
            display.text = (previous - current).ToString();
        }
        else if (function == 3)
        {
            display.text = (previous * current).ToString();
        }
        else if (function == 4)
        {
            display.text = (previous / current).ToString();
        }
    }
}
