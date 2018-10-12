using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public int startSadness;
    public int maxSadness;

    private int sadness;

    private void Start()
    {
        sadness = startSadness;
    }
}
