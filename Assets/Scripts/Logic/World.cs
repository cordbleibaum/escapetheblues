using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public int startSadness;
    public int maxSadness;
    
    public int width = 8;
    public int height = 8;

    private int sadness;
    
    private void Start()
    {
        sadness = startSadness;
    }
}
