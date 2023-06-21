using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour
{
    private Sprite sprite;
    // Start is called before the first frame update
    private void Awake()
    {
#if UNITY_ANDROID
        Debug.Log("Android");
#else
       Debug.Log("other");
#endif
    }
}
