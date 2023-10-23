using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update

    void Start()
    {
        menu.SetActive(true);
    }
    public void NewGameButton()
    {
        menu.SetActive(false);
        print("pressed");
    }
}
