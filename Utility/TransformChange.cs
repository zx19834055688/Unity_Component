using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransformChange : MonoBehaviour
{
    public List<float> transY = new List<float>();

    public void ChangePosY(string tranYNum)
    {
        var num = int.Parse(tranYNum);
        gameObject.GetComponent<RectTransform>().DOAnchorPosY(transY[num - 1],0);
        Debug.Log("changePosY" + transY[num - 1]);
    }
}