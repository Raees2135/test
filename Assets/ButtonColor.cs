using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public Button button; 
    public Text text;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        button.image.color = Color.red;
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ColorChange());

    }

    IEnumerator ColorChange()
    {
        if (button.image.color == Color.red)
        {
            yield return new WaitForSeconds(0.5f);
            button.image.color = Color.green;
        }

        

        if (button.image.color == Color.green)
        {
            yield return new WaitForSeconds(0.5f);
            button.image.color = Color.red;
        }
        

    }

    public void ScorePlus()
    {
        if(button.image.color == Color.red)
        {
            count--;
            text.text = count + " ";
        }

        if (button.image.color == Color.green)
        {
            count++;
            text.text = count + " ";
        }


    }
}
