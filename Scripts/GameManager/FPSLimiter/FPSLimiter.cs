using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLimiter : MonoBehaviour
{
    #region Methods

    [SerializeField]
    int _framesPerSecond = 60;

    // Start is called before the first frame update
    void Start()
    {
        // Set the target frame rate
        Application.targetFrameRate = _framesPerSecond;
    }
    #endregion Methods
}
