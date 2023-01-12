using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWithButton : MonoBehaviour
{
    public static bool SongPlayed = false;

    public AudioSource initialSong;

    private void Start()
    {
        initialSong = GetComponent<AudioSource>();
        if (SongPlayed == false)
        {
            initialSong.Play();
            SongPlayed = true;
        }
    }


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void LoadInitalScene(bool playSong)
    {

        SceneManager.LoadScene("Tutorial");
    }


    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial");
    }


    public void PlaySong()
    {
        initialSong.Play();
    }
}
