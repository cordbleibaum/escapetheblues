﻿using UnityEngine;

namespace Presentation
{
    public enum Direction
    {
        Left, Right, Up, Down
    }
    
    public class Tile : MonoBehaviour
    {
        public bool isLimited;
        public int id;
        public bool once;
        
        public int PosX;
        public int PosY;

        public float SpaceX;
        public float SpaceY;

        public GameObject actionObject;
        public GameObject multiActionObject;

        private bool done;

        private void Start()
        {
            transform.Translate(new Vector2(PosX*SpaceX, PosY*SpaceY));
        }

        private void OnEnable()
        {
            if (actionObject) actionObject.SetActive(false);
        }

        public void OnGoto()
        {
            if (multiActionObject) multiActionObject.SetActive(true);
            if (done) {return;}
            if (once)
            {
                done = true;
            }
            if (actionObject) actionObject.SetActive(true);
        }

        public void OnLeave()
        {
            if (multiActionObject) multiActionObject.SetActive(false);
            if (actionObject) actionObject.SetActive(false);
        }
    }
}
