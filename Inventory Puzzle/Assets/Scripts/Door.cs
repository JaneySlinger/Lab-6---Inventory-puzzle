using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int targetOpenAngle = 90;
    public int targetCloseAngle = 0;
    public int openingSpeed =5;


    public void Open(){
        Debug.Log("opening");
        StartCoroutine(DoorAnimation(targetOpenAngle, openingSpeed));
    }

    public void Close(){
        Debug.Log("closing");
        StartCoroutine(DoorAnimation(targetCloseAngle, openingSpeed));
    }

    private IEnumerator DoorAnimation(int targetAngle, int animationSpeed){
        for(int r = 0; r <animationSpeed; r+= 1){
            transform.localEulerAngles = new Vector3(0,Mathf.LerpAngle(transform.localEulerAngles.y, targetAngle,5f/animationSpeed), 0);
            yield return null;
        }
    }

}
