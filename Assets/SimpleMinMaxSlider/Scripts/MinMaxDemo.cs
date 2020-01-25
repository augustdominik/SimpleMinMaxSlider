using UnityEngine;
using System.Collections;
 
public class MinMaxDemo : MonoBehaviour {

    public string info = "Hover over slider to see tooltip";

    [MinMaxSlider(0,10)] 
    public Vector2 floatTest = new Vector2(2f, 8f);

    [MinMaxSlider(0,10)]
    public Vector2Int intTest;
    
}