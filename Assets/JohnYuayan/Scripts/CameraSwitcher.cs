using UnityEngine;
public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras = new Camera[4];
    public bool changeAudioListener = true;
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            if (cameras[0].enabled)
            {
                EnableCamera(cameras[0], false);
            }
            else
            {
                EnableCamera(cameras[0], true);
            }
        }
        if (Input.GetKeyDown("2"))
        {
            if (cameras[1].enabled)
            {
                EnableCamera(cameras[1], false);
            }
            else
            {
                EnableCamera(cameras[1], true);
            }
        }
        if (Input.GetKeyDown("3"))
        {
            if (cameras[2].enabled)
            {
                EnableCamera(cameras[2], false);
            }
            else
            {
                EnableCamera(cameras[2], true);
            }
        }
        if (Input.GetKeyDown("m"))
        {
            if (cameras[3].enabled)
            {
                EnableCamera(cameras[3], false);
            }
            else
            {
                EnableCamera(cameras[3], true);
            }
        }
    }
    private void EnableCamera(Camera cam, bool
    enabledStatus)
    {
        cam.enabled = enabledStatus;
        if (changeAudioListener)
            cam.GetComponent<AudioListener>().enabled =
            enabledStatus;
    }
}