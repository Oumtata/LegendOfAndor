﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroSelector : MonoBehaviour
{
    private void OnMouseUp()
    {
        SceneManager.LoadScene(2);
    }

}
