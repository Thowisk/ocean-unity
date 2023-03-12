using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class StartVideo : MonoBehaviour
{
    [SerializeField] private GameObject PcPov;
    [SerializeField] private GameObject IntroductionVideo;
    [SerializeField] private GameObject Empty;
    [SerializeField] private VideoPlayer VP;
    
    // Start is called before the first frame update
    void Start()
    {
        // Switch to 1920 x 1080 full-screen
        Screen.SetResolution(1920, 1080, true);
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
        IntroductionVideo.SetActive(true); // Demarre directement la vidéo à ce momment.
        Empty.SetActive(false);
        VP.loopPointReached += EndReached; // cree une instace de Endreached et execute le code, à la fin de la vidéo.
    }

    void EndReached(UnityEngine.Video.VideoPlayer VP)
    {
        Debug.Log(Display.displays.Length);
        VP.gameObject.SetActive(false);
        IntroductionVideo.SetActive(false);
        Empty.SetActive(true);
        Display.displays[1].Activate();
    }
}
