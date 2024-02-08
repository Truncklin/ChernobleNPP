using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.XR;

public class AnimationContoller : MonoBehaviour
{
    private StarterAssetsInputs SAI;
    private Vector2 move;
   private static readonly int X = Animator.StringToHash("x");
   private static readonly int Y = Animator.StringToHash("y");

   private void Start()
   {
       SAI = gameObject.GetComponentInParent<StarterAssetsInputs>();
   }

   void Update()
   {
       move = SAI.move;
        Debug.Log(move.x);
        Debug.Log(move);
        Debug.Log(move.y);
        
        Animator anim = gameObject.GetComponent<Animator>();
        anim.SetFloat(X,move.x );
        anim.SetFloat(Y,move.y );
    }
}
