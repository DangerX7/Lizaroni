using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resolution_script : MonoBehaviour
{/*

    #region Atributes

    #region Player Pref Key Constants

    private const string RESOLUTION_PREF_KEY = "resolution";

    #endregion

    #endregion


    #region Resolution

    [SerializeField]
    private Text resolutionText;

    private Resolution[] resolutions;

    private int currentResolutionIndex = 0;

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;

        currentResolutionIndex = PlayerPrefs.GetInt(RESOLUTION_PREF_KEY, 0);

        SetResolutionText(resolutions[currentResolutionIndex]);
    }

    #region Resolutioon Cycling

    private void SetResolutionText(Resolution resolution)
    {
        resolutionText.text = resolution.width + "x" + resolution.height;
    }

    public void SetNextResolution()
    {
        currentResolutionIndex = GetNextWrappedInmdex(resolutions, currentResolutionIndex);
        SetResolutionText(resolutions[currentResolutionIndex]);
    }
    public void SetPreviousResolution()
    {
        currentResolutionIndex = GetPreviousWrappedInmdex(resolutions, currentResolutionIndex);
        SetResolutionText(resolutions[currentResolutionIndex]);
    }

    #endregion

    #region Apply Resolution

    private void SetAndApplyResolution(int newResolutionIndex)
    {
        currentResolutionIndex = newResolutionIndex;
        ApplyCurrentResolution();
    }

    private void ApplyCurrentResolution()
    {
        ApplyResolution(resolutions[currentResolutionIndex]);
    }

    private void ApplyResolution(Resolution resolution)
    {
        SetResolutionText(resolution);

        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        PlayerPrefs.SetInt(RESOLUTION_PREF_KEY, currentResolutionIndex);
    }

    #endregion

    #region Index Wrap Helpers

    private int GetNextWrappedInmdex<T>(IList<T> collection, int currentIndex)
    {
        if (collection.Count < 1) return 0;
        return (currentIndex + 1) % collection.Count;
    }
    private int GetPreviousWrappedInmdex<T>(IList<T> collection, int currentIndex)
    {
        if (collection.Count < 1) return 0;
        if ((currentIndex - 1) < 0) return collection.Count - 1;
        return (currentIndex - 1) % collection.Count;
    }

    #endregion


    #region Misc Helpers

    public void ApplyChanges()
    {
        SetAndApplyResolution(currentResolutionIndex);
    }

    #endregion*/
}
