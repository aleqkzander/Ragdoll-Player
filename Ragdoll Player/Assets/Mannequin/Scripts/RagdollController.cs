using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    private ConfigurableJoint[] ragdollJoints;
    public float angularxDrive;
    public float angularyzDrive;

    private void Awake()
    {
        ragdollJoints = GetComponentsInChildren<ConfigurableJoint>();
    }

    private void Update()
    {
        foreach (ConfigurableJoint joint in ragdollJoints)
        {
            JointDrive driveX = new JointDrive();
            driveX.positionSpring = angularxDrive;
            driveX.positionDamper = joint.angularXDrive.positionDamper;
            driveX.maximumForce = joint.angularXDrive.maximumForce;

            JointDrive driveYZ = new JointDrive();
            driveYZ.positionSpring = angularyzDrive;
            driveYZ.positionDamper = joint.angularYZDrive.positionDamper;
            driveYZ.maximumForce = joint.angularYZDrive.maximumForce;


            joint.angularXDrive  = driveX;
            joint.angularYZDrive = driveYZ;
        }
    }

}
