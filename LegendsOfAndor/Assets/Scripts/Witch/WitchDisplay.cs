using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WitchDisplay : MonoBehaviour
{
    public static WitchDisplay Instance { get; set; }
    public Hero hero;
    public HeroDisplay heroDisp;
    Button exitButton;


    private void Update()
    {

    }

    void awake()
    {

    }

    public void exitDisplay()
    {
        this.gameObject.SetActive(false);
    }
}
