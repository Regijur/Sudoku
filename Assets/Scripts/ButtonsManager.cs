using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManager : MonoBehaviour
{
    private MyButton[] Buttons;
    public List<MyButton> A;
    public List<MyButton> B;
    public List<MyButton> C;
    public List<MyButton> D;
    public List<MyButton> E;
    public List<MyButton> F;
    public List<MyButton> G;
    public List<MyButton> H;
    public List<MyButton> I;
    
    public List<MyButton> _1;
    public List<MyButton> _2;
    public List<MyButton> _3;
    public List<MyButton> _4;
    public List<MyButton> _5;
    public List<MyButton> _6;
    public List<MyButton> _7;
    public List<MyButton> _8;
    public List<MyButton> _9;
    void Start()
    {
        Buttons = FindObjectsOfType<MyButton>();
        AddToList(Buttons);
    }

    void AddToList(MyButton[] buttons)
    {
        foreach (MyButton button in buttons)
        {
            switch (button.collumnName)
            {
                case "A":
                    A.Add(button);
                    break;
                case "B":
                    B.Add(button);
                    break;
                case "C":
                    C.Add(button);
                    break;
                case "D":
                    D.Add(button);
                    break;
                case "E":
                    E.Add(button);
                    break;
                case "F":
                    F.Add(button);
                    break;
                case "G":
                    G.Add(button);
                    break;
                case "H":
                    H.Add(button);
                    break;
                case "I":
                    I.Add(button);
                    break;
            }
        }
        foreach (MyButton button in buttons)
        {
            switch (button.lineNumber)
            {
                case 1:
                    _1.Add(button);
                    break;
                case 2:
                    _2.Add(button);
                    break;
                case 3:
                    _3.Add(button);
                    break;
                case 4:
                    _4.Add(button);
                    break;
                case 5:
                    _5.Add(button);
                    break;
                case 6:
                    _6.Add(button);
                    break;
                case 7:
                    _7.Add(button);
                    break;
                case 8:
                    _8.Add(button);
                    break;
                case 9:
                    _9.Add(button);
                    break;
            }
        }
        
    }
}
