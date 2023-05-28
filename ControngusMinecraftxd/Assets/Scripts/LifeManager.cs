using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public int startingLives;
    private int lifeCounter;

    void Start()
    {
        lifeCounter = startingLives;
    }

    public void TakeLife()
    {
        lifeCounter--;
    }
    public void ded()
    {
        lifeCounter = 0;
    }
}
