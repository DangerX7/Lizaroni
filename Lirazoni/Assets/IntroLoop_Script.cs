using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using E7.Introloop;

public class IntroLoop_Script : MonoBehaviour
{
    private scene_unlocker_script masterScript;
 //   private SaveTest jsonScript;
    private AudioSource track1, track2, track3, track4;
    private bool firstSearch;
    [SerializeField] int trackNumber;
    [SerializeField] private IntroloopAudio Chapter1;
    [SerializeField] private IntroloopAudio Chapter2;
    [SerializeField] private IntroloopAudio Chapter3;
    [SerializeField] private IntroloopAudio Chapter4;
    [SerializeField] private IntroloopAudio Chapter5;
    [SerializeField] private IntroloopAudio Bonus;
    [SerializeField] private IntroloopAudio Boss;
    [SerializeField] private IntroloopAudio FinalBoss;
    [SerializeField] private IntroloopAudio TitleScreen;
    [SerializeField] private IntroloopAudio ClassicMode;
    [SerializeField] private IntroloopAudio Map;
    [SerializeField] private IntroloopAudio VersusEasy;
    [SerializeField] private IntroloopAudio VersusNormal;
    [SerializeField] private IntroloopAudio VersusHard;

    [Space]
    [SerializeField] private IntroloopAudio assault;

    [Range(0, 2f)] [SerializeField] private float assaultFade;

    [Space] [SerializeField] private IntroloopAudio compete;

    [Range(0, 2f)] [SerializeField] private float competeFade;

    [Space]
    [Tooltip("This is not connected to anything in the scene, but to the prefab asset that" +
             "has AudioSource on it as a template. Now it is easy to adjust your template " +
             "from the Project pane.")]
    [SerializeField] private AudioSource templateForDemoSubclassPlayer;
    public void Awake()
    {
        Debug.Log("x1");
        masterScript = GameObject.Find("SceneUnlocker").GetComponent<scene_unlocker_script>();

        switch (trackNumber)
        {
            case 1:
                Chapter1Bgm();
                break;
            case 2:
                Chapter2Bgm();
                break;
            case 3:
                Chapter3Bgm();
                break;
            case 4:
                Chapter4Bgm();
                break;
            case 5:
                Chapter5Bgm();
                break;
            case 6:
                BonusBgm();
                break;
            case 7:
                BossBgm();
                break;
            case 8:
                FinalBossBgm();
                break;
            case 10:
                TitleScreenBgm();
                break;
            case 11:
                MapBgm();
                break;
            case 12:
                ClassicModeBgm();
                break;
            case 13:
                VersusEasyBgm();
                break;
            case 14:
                VersusNormalBgm();
                break;
            case 15:
                VersusHardBgm();
                break;
        }

        //   jsonScript = GameObject.Find("MASTER OBJECT").GetComponent<SaveTest>();
        //  if (!jsonScript.so.dontRestartMusic)
        {
            //////
        }
     //   jsonScript.Save();
    }

    /*
    private void Update()
    {
        if (!firstSearch)
        {
            if (GameObject.Find("AudioSource 1x") == null)
            {
                track1 = GameObject.Find("AudioSource 1").GetComponent<AudioSource>();
                track1.name = "AudioSource 1x";
            }
            else
            {
                track1 = GameObject.Find("AudioSource 1x").GetComponent<AudioSource>();
            }
            track2 = GameObject.Find("AudioSource 1").GetComponent<AudioSource>();
            if (GameObject.Find("AudioSource 2x") == null)
            {
                track3 = GameObject.Find("AudioSource 2").GetComponent<AudioSource>();
                track3.name = "AudioSource 2x";
            }
            else
            {
                track3 = GameObject.Find("AudioSource 2x").GetComponent<AudioSource>();
            }
            track4 = GameObject.Find("AudioSource 2").GetComponent<AudioSource>();
            firstSearch = true;
        }
     //   track1.volume = jsonScript.so.BGMvol;
     //   track2.volume = jsonScript.so.BGMvol;
     //   track3.volume = jsonScript.so.BGMvol;
     //   track4.volume = jsonScript.so.BGMvol;
    }
    */

    #region BGM Play Methods

    public void Chapter1Bgm()
    {
        IntroloopPlayer.Instance.Play(Chapter1);
    }

    public void Chapter2Bgm()
    {
        IntroloopPlayer.Instance.Play(Chapter2);
    }

    public void Chapter3Bgm()
    {
        IntroloopPlayer.Instance.Play(Chapter3);
    }

    public void Chapter4Bgm()
    {
        IntroloopPlayer.Instance.Play(Chapter4);
    }

    public void Chapter5Bgm()
    {
        IntroloopPlayer.Instance.Play(Chapter5);
    }

    public void BonusBgm()
    {
        IntroloopPlayer.Instance.Play(Bonus);
    }

    public void BossBgm()
    {
        IntroloopPlayer.Instance.Play(Boss);
    }

    public void FinalBossBgm()
    {
        IntroloopPlayer.Instance.Play(FinalBoss);
    }

    public void TitleScreenBgm()
    {
        IntroloopPlayer.Instance.Play(TitleScreen);
    }

    public void ClassicModeBgm()
    {
        IntroloopPlayer.Instance.Play(ClassicMode);
    }

    public void MapBgm()
    {
        IntroloopPlayer.Instance.Play(Map);
    }

    public void VersusEasyBgm()
    {
        IntroloopPlayer.Instance.Play(VersusEasy);
    }

    public void VersusNormalBgm()
    {
        IntroloopPlayer.Instance.Play(VersusNormal);
    }

    public void VersusHardBgm()
    {
        IntroloopPlayer.Instance.Play(VersusHard);
    }
    #endregion


    public void PauseBgm()
    {
        IntroloopPlayer.Instance.Pause();
    }

    public void ResumeBgm()
    {
        IntroloopPlayer.Instance.Resume();
    }

    public void StopBgm()
    {
        IntroloopPlayer.Instance.Stop();
    }
}
