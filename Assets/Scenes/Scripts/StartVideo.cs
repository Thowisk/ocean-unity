using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartVideo : MonoBehaviour
{
    private string path;
    [SerializeField] private GameObject PcPov;
    [SerializeField] private GameObject IntroductionVideo;
    
    // Start is called before the first frame update
    void Start()
    {
        PcPov.SetActive(false);
        IntroductionVideo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartExp()
    {
        
    }

    public void StartingVideo()
    {
        
    }
}
