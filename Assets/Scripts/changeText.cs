using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class changeText : MonoBehaviour
{
    [SerializeField] float waittime;
    Text textElement;
    [SerializeField] Spin Spinner;
    IEnumerator wait(float waitTime){ //creating a function
        yield return new WaitForSeconds(waitTime); //tell unity to wait!!
    }

    // Start is called before the first frame update
    void Start()
    {
        textElement = this.GetComponent<Text>();
        
        InvokeRepeating("textChange", 0.5f, 1.0f);

    }

    void textChange(){
        textElement.GetComponent<UnityEngine.UI.Text>().text = Spinner.TurnRate.ToString();
        Debug.Log("TurnRate:" + Spinner.TurnRate);
    }
    // Update is called once per frame
    // void Update()
    // {
    //     // float Trate = Spinner.GetComponent(TurnRate);
    //     Debug.Log(Spinner.TurnRate);
    //     textElement.GetComponent<UnityEngine.UI.Text>().text = Spinner.TurnRate.ToString();


    // }
}
