using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private ConfigurableJoint _joint;
    [SerializeField] private Transform _pelvisTransform;

    void FixedUpdate() {
        Vector3 toTarget = _target.position - _pelvisTransform.position;
        Vector3 toTargetXZ = new Vector3(toTarget.x, 0f, toTarget.z);
        Quaternion rotation = Quaternion.LookRotation(toTargetXZ);

        _joint.targetRotation = Quaternion.Inverse(rotation);
    }
}
