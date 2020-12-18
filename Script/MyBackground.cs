using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBackground : MonoBehaviour
{
   public float speed;
   public Renderer render;
   

   void Start() {
      
    render.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
   }

   void Update() {
       render.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
   }
}
