using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLineManager : MonoBehaviour
{

    public AudioSource[] voiceLine;

    public int nextVoiceLine;

    

    public GameObject voiceLineHolder;

    

    public void Start()
    {
        nextVoiceLine = 0;
    }

    public void Update()
    {

        
    }
    public void NextVoiceLine()
    {

        voiceLineHolder.SetActive(false);
        voiceLineHolder.SetActive(true);



        if (nextVoiceLine < voiceLine.Length)
        {
            voiceLine[nextVoiceLine].Play();

            nextVoiceLine += 1;
            Debug.Log("VOICELINES:" + nextVoiceLine);
            //Debug.Log("VOICELINES:");
        }




    }

}
