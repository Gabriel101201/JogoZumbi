using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class IKFoot : MonoBehaviour
{
    public Animator anim;
    public Transform foot1, foot2, spine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnAnimatorIK(int layerIndex)
    {
        if (Physics.Raycast(spine.position, foot1.transform.position - spine.position, out RaycastHit hit, 2))
        {
            Debug.DrawLine(spine.position, hit.point, Color.red);

            anim.SetIKPosition(AvatarIKGoal.LeftFoot, hit.point);
            anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);
        }

        if (Physics.Raycast(spine.position, foot2.transform.position - spine.position, out RaycastHit hit2, 2))
        {
            Debug.DrawLine(spine.position, hit2.point, Color.red);

            anim.SetIKPosition(AvatarIKGoal.RightFoot, hit2.point);
            anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);
        }
    }
}
