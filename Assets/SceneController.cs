using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Audio.instance.Victory();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Audio.instance.Loose();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Audio.instance.StopAllSounds();
        }
    }
}
