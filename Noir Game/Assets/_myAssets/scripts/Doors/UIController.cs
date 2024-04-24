using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public static UIController Instance;
    public Image BlackFadeScreen;
    Sequence sq;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    public void FadeIN()
    {
        BlackFadeScreen.DOFade(1f, 1f);
    }

    public void FadeOUT()
    {
        BlackFadeScreen.DOFade(0f, 1f);
    }
}
