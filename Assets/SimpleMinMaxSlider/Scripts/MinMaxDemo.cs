using UnityEngine;
using System.Collections;
 
public class MinMaxDemo : MonoBehaviour {

    public string info = "Hover over slider to see tooltip";

    [MinMax(0,10)] 
    public Vector2 floatTest = new Vector2(2f, 8f);

    [MinMax(0,10)]
    public Vector2Int intTest;
    
}