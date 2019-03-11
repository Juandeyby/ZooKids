using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore.Examples.Common;
using UnityEngine.UI;

public class MainView : App
{
    public Camera camera;
    public DetectedPlaneGenerator detectedPlanePrefab;
    public AudioSource audioSource;

    [Header("Canvas Buttons")]
    public Button backButton;
    public Button homeButton;

    [Header("Models 3D")]
    public GameObject objectPrefab;
    public GameObject lunesHabitats;
    public GameObject[] lunesHabitatsAnimals;
    public GameObject[] lunesMamiferos;
    public GameObject[] lunesReptiles;
    public GameObject[] lunesAves;
    public GameObject[] lunesAnfibios;
    public GameObject[] lunesPeces;

    void Start()
    {
        homeButton.onClick.AddListener(app.mainController.actionHome);
        backButton.onClick.AddListener(app.mainController.actionBack);
    }
}
