using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GD.MinMaxSlider;
public class SliderTest : MonoBehaviour
{
    [MinMaxSlider(0, 100)]
    public Vector2 slider;
}
