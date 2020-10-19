using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public Image img;
    public Sprite[] images;

    public void ButtonDown()
    {
        int num = Random.Range(0, images.Length);
        img.sprite = images[num];
    }
}
