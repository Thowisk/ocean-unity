using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class StartVideo : MonoBehaviour
{
    private string path = "C:\\Users\\XeNoZ\\OneDrive\\Bureau\\Fiddlesticks.mp4"; //path to the video on the computer -> Must Modify !
    [SerializeField] private GameObject PcPov;
    [SerializeField] private GameObject IntroductionVideo;
    [SerializeField] private GameObject Empty;
    [SerializeField] private VideoPlayer VP;
    
    // Start is called before the first frame update
    void Start()
    {
        PcPov.SetActive(true);
        IntroductionVideo.SetActive(false);
        Empty.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartExp()
    {
        PcPov.SetActive(false);
        IntroductionVideo.SetActive(true);
        Empty.SetActive(false);
        StartingVideo();

    }

    public void StartingVideo()
    {
        VP.gameObject.SetActive(true);
        VP.playOnAwake = false;
        VP.url = path;
        VP.Prepare();
        VP.Play();
        VP.loopPointReached -= EndReached;
    }

    void EndReached(UnityEngine.Video.VideoPlayer VP)
    {
        VP.gameObject.SetActive(false);
        Empty.SetActive(true);
    }
}
