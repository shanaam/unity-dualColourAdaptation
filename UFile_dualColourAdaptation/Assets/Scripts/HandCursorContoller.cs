using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCursorContoller : MonoBehaviour {

    //link to the actual hand position object
    public GameObject realHand;
    public ExampleController exampleController;     //the experiment controller


    // Use this for initialization
    void Start () {
        // disable the whole task initially to give time for the experimenter to use the UI
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localPosition = realHand.transform.position - transform.parent.transform.position;

        Vector3 realHandPosition = realHand.transform.position;
        Vector3 rotatorObjectPosition = transform.parent.transform.position;

        transform.localPosition = realHandPosition - rotatorObjectPosition;

        //turn cursor red for first type of rotation
        if (exampleController.rotationAngle == exampleController.rotation1)
        {
            GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
        }

        else if (exampleController.rotationAngle == exampleController.rotation2)
        {
            GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
        }
    }
}
