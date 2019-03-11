using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekButtonView : App
{
    public Button[] weekButtons;

    void Start()
    {
        weekButtons[0].onClick.AddListener(app.mainController.mainLunes);
        weekButtons[1].onClick.AddListener(app.mainController.mainMartes);
        weekButtons[2].onClick.AddListener(app.mainController.mainMiercoles);
        weekButtons[3].onClick.AddListener(app.mainController.mainJueves);
        weekButtons[4].onClick.AddListener(app.mainController.mainViernes);
    }
}
