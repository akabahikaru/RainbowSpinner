using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChange : MonoBehaviour
{

    [SerializeField] Spin Spinner;

    public List<Color> colorList = new List<Color>();

    int x;
    float r;

    // Start is called before the first frame update
    void Start()
    {
        
         InvokeRepeating("changeColor", 0.5f, 1.0f);
    }

    void checkColorZone(){
        r = Spinner.TurnRate / 100 - 1;
        x = (int)r;
            if (x <= 0){ 
        x=0;
        }
        if (x >= 7){ 
            x=7;
            }
        Debug.Log(x);
    }

    void changeColor(){
        checkColorZone();
        gameObject.GetComponent<SpriteRenderer>().color = colorList[x];
    }
    // Update is called once per frame

}
