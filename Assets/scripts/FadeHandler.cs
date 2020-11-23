﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class FadeHandler : MonoBehaviour
{
   private float _fadeDuration = 2f;
 
     private void Start()
     {
         FadeToBlack();
         Invoke("FadeFromBlack", _fadeDuration);
     }
     private void FadeToBlack()
     {
         //set start color
         SteamVR_Fade.Start(Color.clear, 0f);
         //set and start fade to
         SteamVR_Fade.Start(Color.black, _fadeDuration);
     }
     private void FadeFromBlack()
     {
         //set start color
         SteamVR_Fade.Start(Color.black, 0f);
         //set and start fade to
         SteamVR_Fade.Start(Color.clear, _fadeDuration);
     }
}
