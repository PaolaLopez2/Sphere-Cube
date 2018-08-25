﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeChangesSphereColor {
    public class GameMaster : MonoBehaviour {

        public GameObject Sphere;

        public Color theColor;


        Color GetRandomColor()
        {
            float r = Random.Range(0.0f, 1.0f);
            float g = Random.Range(0.0f, 1.0f);
            float b = Random.Range(0.0f, 1.0f);
            return new Color(r, g, b);
        }

        void ChangeColor()
        {
            gameObject.GetComponent<Renderer>().material.color = this.GetRandomColor();
        }

        // Use this for initialization
        void Start () {
            
        }

        // Update is called once per frame
        void Update () {
            void ChangeColor()
            {
                Sphere.GetComponent<Renderer>().material.color = this.GetRandomColor();
            }

            void OnMouseDown()
            {
                this.ChangeColor;
            }
        }
    }

}
