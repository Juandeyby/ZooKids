using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : App
{
    //Touch models 3D (remember Space.Self))
    [HideInInspector]
    public GameObject objectTemp;
    [HideInInspector]
    public float k_ModelRotation = 180.0f;
    [HideInInspector]
    public Vector3 positionTouch;
    [HideInInspector]
    public Quaternion rotationTouch;

    //Week
    public void mainLunes()
    {
        Destroy(objectTemp);
        app.mainView.backButton.gameObject.SetActive(true);
        app.mainView.homeButton.gameObject.SetActive(true);

        objectTemp = Instantiate(app.mainView.lunesHabitats, positionTouch, rotationTouch);
        objectTemp.transform.Rotate(0, k_ModelRotation, 0, Space.Self);
    }
    public void mainMartes()
    {
        Destroy(objectTemp);
    }
    public void mainMiercoles()
    {
        Destroy(objectTemp);
    }
    public void mainJueves()
    {
        Destroy(objectTemp);
    }
    public void mainViernes()
    {
        Destroy(objectTemp);
    }

    //Habitats Lunes
    public void mamiferosHabitatsLunes()
    {
        Destroy(objectTemp);
        objectTemp = Instantiate(app.mainView.lunesHabitatsAnimals[0], positionTouch, rotationTouch);
        objectTemp.transform.Rotate(0, k_ModelRotation, 0, Space.Self);
    }
    public void mamiferosHabitatsMartes()
    {

    }
    public void mamiferosHabitatsMiercoles()
    {

    }
    public void mamiferosHabitatsJueves()
    {

    }
    public void mamiferosHabitatsViernes()
    {

    }

    //Buttons Canvas
    public void actionBack()
    {
        if (objectTemp.name.Equals("lunesHabitats(Clone)"))
        {
            backModel3D(app.mainView.objectPrefab);
            app.mainView.backButton.gameObject.SetActive(false);
            app.mainView.homeButton.gameObject.SetActive(false);
            return;
        }

        foreach (GameObject temp in app.mainView.lunesHabitatsAnimals)
        {
            if (objectTemp.name.Equals(temp.name + "(Clone)"))
            {
                backModel3D(app.mainView.lunesHabitats);
                return;
            }
        }
    }

    private void backModel3D(GameObject gameObject)
    {
        Destroy(objectTemp);

        objectTemp = Instantiate(gameObject, positionTouch, rotationTouch);
        objectTemp.transform.Rotate(0, k_ModelRotation, 0, Space.Self);
    }

    public void actionHome()
    {
        Destroy(objectTemp);
        app.mainView.backButton.gameObject.SetActive(false);
        app.mainView.homeButton.gameObject.SetActive(false);

        objectTemp = Instantiate(app.mainView.objectPrefab, positionTouch, rotationTouch);
        objectTemp.transform.Rotate(0, k_ModelRotation, 0, Space.Self);
    }
}
