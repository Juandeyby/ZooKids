using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HabitatsLunesView : App
{
    public Button[] habitatsButtonsLunes;

    void Start()
    {
        habitatsButtonsLunes[0].onClick.AddListener(app.mainController.mamiferosHabitatsLunes);
        habitatsButtonsLunes[1].onClick.AddListener(app.mainController.mamiferosHabitatsMartes);
        habitatsButtonsLunes[2].onClick.AddListener(app.mainController.mamiferosHabitatsMiercoles);
        habitatsButtonsLunes[3].onClick.AddListener(app.mainController.mamiferosHabitatsJueves);
        habitatsButtonsLunes[4].onClick.AddListener(app.mainController.mamiferosHabitatsViernes);
    }
}
