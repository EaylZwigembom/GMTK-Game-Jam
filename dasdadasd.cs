using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code2 : MonoBehaviour
{
    public string namee;
    public int age = 12;
    public Text msg;
    [SerializeField] Text shit;

    public void OnClick()
    {
        if (age < 10)
        {
            msg.text = "You are too young";
        }
        else
        {
           w msg.text = "You can enter the game";
        }
    }

    public void Click()
    {
        print(age++);
    }
}
