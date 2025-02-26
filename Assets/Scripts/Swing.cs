using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private Seat _seat;
    [SerializeField] private float _resetTime;

    private HingeJoint _seatJoint;
    private JointMotor _hingeMotor;

    private void Awake()
    {
        _seatJoint = _seat.GetComponent<HingeJoint>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            _seatJoint.useMotor = true;
            Invoke("ResetSwing", _resetTime);
        }
    }

    private void ResetSwing()
    {
        _seatJoint.useMotor = false;
    }
}
