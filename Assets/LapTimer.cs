using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LapTimer : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;
    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public TMP_Text timerText;

    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        MilliDisplay = MilliCount.ToString("F0");
        timerText.text = "" + MilliDisplay;

        if(MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }

        if(SecondCount <= 9)
        {
            SecondBox.GetComponent<TMP_Text>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<TMP_Text>().text = "" + SecondCount + ".";
        }

        if(SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }

        if(MinuteCount <= 9)
        {
            MinuteBox.GetComponent<TMP_Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<TMP_Text>().text = "" + MinuteCount + ":";
        }
    }
}
