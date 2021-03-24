using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{

    SpriteRenderer board;
    SpriteRenderer[] squares;
    text[] colorIds;

    Dictionary<string, Color> colorDictionary = new Dictionary<string, Color>();
    Color[][] colors;

    string[] ALPHABET = { "A", "B", "C" };
    Dictionary<string, Color> cardDictionary = new Dictionary<string, Color>();

    // Start is called before the first frame update
    void Start()
    {
        board = GetComponent<SpriteRenderer>();
        squares = new SpriteRenderer[]
        {
            GameObject.Find("Color 1").GetComponent<SpriteRenderer>(),
            GameObject.Find("Color 2").GetComponent<SpriteRenderer>(),
            GameObject.Find("Color 3").GetComponent<SpriteRenderer>(),
            GameObject.Find("Color 4").GetComponent<SpriteRenderer>()
        };

        colorIds = new SpriteRenderer[]
        {
            GameObject.Find("Color ID 1").GetComponent<SpriteRenderer>(),
            GameObject.Find("Color ID 2").GetComponent<SpriteRenderer>(),
            GameObject.Find("Color ID 3").GetComponent<SpriteRenderer>(),
            GameObject.Find("Color ID 4").GetComponent<SpriteRenderer>()

        };

        //colors = new Color[]
        //    { new Color(97, 43, 15, 255),
        //      new Color(107, 39, 16, 255),
        //      new Color(117, 34, 20, 255)
        //    },{ }
        colorDictionary.Add("0,A", new Color(97f/255f, 43f/255, 15f/255f,1));
        colorDictionary.Add("1,A", new Color(107f/255f, 39/255f, 16/255f, 1));
        colorDictionary.Add("2,A", new Color(117f/255f, 34f/255f, 20f/255f, 1));
        colorDictionary.Add("0,B", new Color(136f/255f, 75f/255f, 31f/255f, 1));
        colorDictionary.Add("1,B", new Color(148f/255f, 68f/255f, 31f/255f, 1));
        colorDictionary.Add("2,B", new Color(156f/255f, 63/255f, 32f/255f, 1));
        colorDictionary.Add("0,C", new Color(166f/255f, 97f/255f, 40/255f, 1));
        colorDictionary.Add("1,C", new Color(172/255f, 91/255f, 38/255f, 1));
        colorDictionary.Add("2,C", new Color(186f/255f, 90f/255f, 39f/255f, 1));

        for (int i = 0; i<4; i++)
        {
            int x = ((int)Random.Range(0f, 8f))/3;
            int y = ((int)Random.Range(0f, 8f))%2;
            while(cardDictionary.ContainsKey(x + "," + ALPHABET[y]))
            {
                x = ((int)Random.Range(0f, 8f)) / 3;
                y = ((int)Random.Range(0f, 8f)) % 2;
            }
            squares[i].color = colorDictionary[x + "," + ALPHABET[y]];
            colorIds[i].text
            cardDictionary[x + "," + ALPHABET[y]] = squares[i].color;
        }
       
    }

    // Update is called once per frame
    void Update()
    {


    }
}
