using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartView : StartApp
{
    [SerializeField]
    private Button _startButton;
    public AudioClip audio; 

    void Start()
    {
        _startButton.onClick.AddListener(app.startController.StartGame);
    }
}
