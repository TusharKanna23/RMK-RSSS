using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 9;

    [Header("VR Camera")]
    public Transform playerCamera;

    [Header("Rotation")]
    public float rotationSpeed = 80f;

    Rigidbody rigidbody;

    InputDevice leftController;
    InputDevice rightController;

    Vector2 leftJoystick;
    Vector2 rightJoystick;

    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        // Get VR controllers
        leftController = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        rightController = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    void Update()
    {
        // Read joystick inputs
        leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out leftJoystick);
        rightController.TryGetFeatureValue(CommonUsages.primary2DAxis, out rightJoystick);

        // GTA style smooth rotation using right joystick
        float rotation = rightJoystick.x * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotation);
    }

    void FixedUpdate()
    {
        IsRunning = canRun;

        float targetMovingSpeed = IsRunning ? runSpeed : speed;

        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        // Movement relative to camera direction
        Vector3 forward = playerCamera.forward;
        Vector3 right = playerCamera.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 direction = forward * leftJoystick.y + right * leftJoystick.x;

        Vector3 velocity = direction * targetMovingSpeed;

        rigidbody.velocity = new Vector3(velocity.x, rigidbody.velocity.y, velocity.z);
    }
}