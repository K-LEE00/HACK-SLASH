﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleUIController : MonoBehaviour
{

    public void StartGame()
    {
        GameManager.Instance.ChangeSceneToBaseCamp();
    }
}
