using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public MainApplication app { get { return GameObject.FindObjectOfType<MainApplication>(); } }
}

public class MainApplication : MonoBehaviour
{
    public MainModel mainModel;
    public MainController mainController;
    public MainView mainView;
}
