using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLimiter : MonoBehaviour
{
    #region Fields

    public int _framesPerSecond;  // This variable stores the desired frames per second (FPS).

    #endregion Fields

    #region Methods

    // Start is called before the first frame update
    void Start()
    {
        // Set the target frame rate to the value stored in _framesPerSecond.
        Application.targetFrameRate = _framesPerSecond;
    }

    #endregion Methods
}
