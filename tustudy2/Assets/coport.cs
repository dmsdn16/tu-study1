using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

[Serializable]
public class ComplexType
{
    public string Name;
    public int age;
    public float height;
}
public class coport : MonoBehaviour
{

    public ComplexType StudyName;

    // Start is called before the first frame update
    void Start()
    {
        print(message:"���� ��ŸƮ") ;
    }

    // Update is called once per frame

    private const float AttackInterval = 3f;

    private float _AttackIntervqlTimer;
    void Update()
    {
        _AttackIntervqlTimer += Time.deltaTime;

        if(_AttackIntervqlTimer > 3f)
        {
            PrintTest();
            _AttackIntervqlTimer = 0f;
        }
    }

    void PrintTest()
    {
        print(message: "����");
    }
}
