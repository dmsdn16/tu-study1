using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyA : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject studyBobject;
    void Start()
    {
        studyBobject = new GameObject(name:"B");
        studyBobject.AddComponent<StudyB>();
        print(studyBobject.name);

        var StudyB = studyBobject.GetComponent<StudyB>();
        studyBobject.SendMessage(methodName: "SayHello");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
