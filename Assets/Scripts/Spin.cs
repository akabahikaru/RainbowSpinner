using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
    [SerializeField] Transform handle;
    [SerializeField] Camera mainCamera;
    [SerializeField] Canvas canvas;
    [SerializeField] float frame;

    public float TurnRate;
    Vector3 mousePos;
    Vector2 movePos;
    Vector2 pos;
    public Canvas parentCanvas;
    Quaternion r;
    float angle;

    public void Start()
    {

        // RectTransformUtility.ScreenPointToLocalPointInRectangle(
        //     parentCanvas.transform as RectTransform, Input.mousePosition,
        //     parentCanvas.worldCamera,
        //     out pos);
    }
    void Update(){
        
        float angle1 = angle;

        // Get Mouse Position On UI
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            parentCanvas.transform as RectTransform,
            Input.mousePosition, parentCanvas.worldCamera,
            out movePos);

        // rotate pannel to mouse
        if (Input.GetKey ("mouse 0")){
            
            mousePos = new Vector3(movePos.x, movePos.y, 0f);
            Vector2 dir = mousePos - handle.position;
            angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
            angle = (angle <= 0) ? (360 + angle) : angle;
            r = Quaternion.AngleAxis (angle + 135f, Vector3.forward);
            handle.rotation = r;
            angle = ((angle >= 315) ? (angle - 360) : angle) +45;
        }

        //Calculate spin rate


        float angleChange = Math.Abs(angle-angle1);
        TurnRate = angleChange / frame;

        // Debug.Log("TurnRate" + TurnRate);
    }
}

