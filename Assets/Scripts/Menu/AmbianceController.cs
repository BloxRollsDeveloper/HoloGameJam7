using System;
using UnityEngine;

public class AmbienceController : MonoBehaviour
{
   public AudioClip ambientClip;
   public AudioSource audioSource;
   
   public static AmbienceController instance;
   private void Awake()
   {
      if (instance == null)
      {
         instance = this;
         DontDestroyOnLoad(gameObject);
      }
      else
      {
         Destroy(gameObject);
      }
   }
}
