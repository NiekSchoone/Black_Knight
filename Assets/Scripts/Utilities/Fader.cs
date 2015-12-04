//Written by Rob Verhoef
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fader : MonoBehaviour
{
    private Image _fade;

    void Awake ()
    {
        _fade = GameObject.Find("Fade").GetComponent<Image>();
    }

    public void FadeIn ()
    {
        //The screen fades in
        _fade.CrossFadeColor(Color.clear, 5.0f, true, true);
    }

    public void FadeOut ()
    {
        //The screen fades out
        _fade.CrossFadeColor(Color.black, 1.5f, true, true);
    }
}
