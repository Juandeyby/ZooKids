using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartApp : MonoBehaviour
{
    public StartApplication app { get { return GameObject.FindObjectOfType<StartApplication>(); } }
}

public class StartApplication : MonoBehaviour
{
    public StartModel startModel;
    public StartController startController;
    public StartView startView;
}
