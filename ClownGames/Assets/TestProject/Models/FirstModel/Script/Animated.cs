using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animated : MonoBehaviour
{
    [SerializeField] private PhysicMaterial _defaultFriction;
    [SerializeField] private PhysicMaterial _zeroFriction;

    [SerializeField] private Collider _frontRightLeg;
    [SerializeField] private Collider _hindRightLeg;
    [SerializeField] private Collider _frontLeftLeg;
    [SerializeField] private Collider _hindLeftLeg;

    public void SetLeftFriction() 
    {
        _frontRightLeg.material = _defaultFriction;
        _hindRightLeg.material = _zeroFriction;

        _frontLeftLeg.material = _zeroFriction;
        _hindLeftLeg.material = _defaultFriction;
    }

    public void SetRightFriction()
    {
        _frontRightLeg.material = _zeroFriction;
        _hindRightLeg.material = _defaultFriction;

        _frontLeftLeg.material = _defaultFriction;
        _hindLeftLeg.material = _zeroFriction;
    }
}
