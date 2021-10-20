using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageNavigation : MonoBehaviour
{
    public void Start_page()
    {
        SceneManager.LoadScene("Start_page");
    }
    public void Navigation()
    {
        SceneManager.LoadScene("Navigation");
    }

    public void About_us()
    {
        SceneManager.LoadScene("About_us");
    }

    public void Logo_detection()
    {
        SceneManager.LoadScene("ObjectDetectionYoloV4");
    }

    public void QrReader()
    {
        SceneManager.LoadScene("QrReader");
    }

}