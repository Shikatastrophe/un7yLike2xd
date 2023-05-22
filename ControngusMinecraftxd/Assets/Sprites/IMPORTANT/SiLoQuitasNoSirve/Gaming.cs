using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // import the namespace

public class Gaming : MonoBehaviour
{
    // Start is called before the first frame updat
void Start()
{
    string path = "Assets/Sprites/IMPORTANT/SiLoQuitasNoSirve/OralePincheViejaTeDijeCartaBlanca.jpg"; // specify the file path
    if (!File.Exists(path)) // check if the file does not exist
    {
        Debug.Log("ORALE PINCHE VIEJA, TE DIJE CARTA BLAN-CA"); // print a message
        Application.Quit(); // quit the game
    }
}
}
