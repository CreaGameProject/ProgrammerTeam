using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayBaseball : MonoBehaviour
{
    private VideoPlayer player;
    [SerializeField] VideoClip[] video;
    private int rand;

    void Start()
    {
        player = this.GetComponent<VideoPlayer>();
        PlayMovie();
    }

    void Update()
    {
        if (rand == 2 && !player.isPlaying)
        {
            SceneManager.LoadScene("Ending");
        }
        else if (!player.isPlaying)
        {
            SceneManager.LoadScene("EatHoney");
        }
    }

    public void PlayMovie()
    {
        rand = Random.Range(0, 3);
        player.clip = video[rand];
        player.Play();
    }
}
