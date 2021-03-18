using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{

    SpriteRenderer board;
    SpriteRenderer[] squares;
    Dictionary<string, Color> colorDictionary = new Dictionary<string, Color>();
    Color[][] colors;
    
    // Start is called before the first frame update
    void Start()
    {
        board = GetComponent<SpriteRenderer>();
        squares = new SpriteRenderer[]
        {
            GameObject.Find("Square1").GetComponent<SpriteRenderer>(),
            GameObject.Find("Square2").GetComponent<SpriteRenderer>(),
            GameObject.Find("Square3").GetComponent<SpriteRenderer>(),
            GameObject.Find("Square4").GetComponent<SpriteRenderer>()
        };

        //colors = new Color[]
        //    { new Color(97, 43, 15, 255),
        //      new Color(107, 39, 16, 255),
        //      new Color(117, 34, 20, 255)
        //    },{ }
        colorDictionary.Add("A,0", new Color(97f/255f, 43f/255, 15f/255f,1));
        colorDictionary.Add("A,1", new Color(107f/255f, 39/255f, 16/255f, 1));
        colorDictionary.Add("A,2", new Color(117f/255f, 34f/255f, 20f/255f, 1));
        colorDictionary.Add("B,0", new Color(136f/255f, 75f/255f, 31f/255f, 1));
        colorDictionary.Add("B,1", new Color(148f/255f, 68f/255f, 31f/255f, 1));
        colorDictionary.Add("B,2", new Color(156f/255f, 63/255f, 32f/255f, 1));
        colorDictionary.Add("C,0", new Color(166f/255f, 97f/255f, 40/255f, 1));
        colorDictionary.Add("C,1", new Color(172/255f, 91/255f, 38/255f, 1));
        colorDictionary.Add("C,2", new Color(186f/255f, 90f/255f, 39f/255f, 1));

        //TODO: Random
        squares[0].color = colorDictionary["A,0"];
       
    }

    // Update is called once per frame
    void Update()
    {


    }
}
