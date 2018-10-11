using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCapture : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            int fileNumber = 1;
            while (System.IO.File.Exists("ScreenShots/" + fileNumber + ".png"))
            {
                fileNumber++;
            }
            ScreenCapture.CaptureScreenshot("ScreenShots/" + fileNumber + ".png");
        }
    }
}
