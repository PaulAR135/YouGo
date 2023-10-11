using System;
using UnityEngine;
using UnityEngine.Events;

namespace MetaYouGo.Scripts.Player {
  [RequireComponent(typeof(Camera))]
  public class PlayerCameraController : MonoBehaviour
  {
    public VariableJoystick RotationVariableJoystick;
    public VariableJoystick MovingVariableJoystick;
    
    public float MovementSpeed = 150f;
    public float RotationSpeed = 30f;
    public float MinXRotation = 0;
    public float MaxXRotation = 90;
    public float MinHeight = 2f;
    public float MaxHeight = 600f;

    private Vector3 StartPosition;
    private float DownloadDistance = 300f; //TODO: transfer to some settings file
    
    [Serializable]
    public class MoveEvent : UnityEvent<Vector3> {}
    
    public MoveEvent OnMove = new MoveEvent();
    public UnityEvent OnRotate = new UnityEvent();
    public UnityEvent OnTransform = new UnityEvent();
    
    // when camera change position more than DownloadDistance, event happens
    public delegate void PositionChangeAction();
    public static event PositionChangeAction OnPositionChanged;
    
    private float Azimuth;
    private float Inclination;

    public void InitializeAzimuthAndInclination() {
      Azimuth = transform.eulerAngles.y;
      Inclination = transform.eulerAngles.x;
    }

    private void Awake() {
      InitializeAzimuthAndInclination();
      CameraInitSettings();
    }

    private void CameraInitSettings()
    {
      StartPosition = transform.position;
    }

    private void Update() {
      
      bool isMoving = MovingVariableJoystick.Vertical != 0 || MovingVariableJoystick.Horizontal != 0;
      bool isRotating = RotationVariableJoystick.Vertical != 0 || RotationVariableJoystick.Horizontal != 0;

      if (!isMoving && !isRotating) {
        return;
      }

      float xInput = MovingVariableJoystick.Vertical;
      float zInput = MovingVariableJoystick.Horizontal;
      float rotX = - RotationVariableJoystick.Vertical;
      float rotY = RotationVariableJoystick.Horizontal;
      
      Vector3 positionBefore = transform.position;
      
      // check position changing
      if (OnPositionChanged != null && (positionBefore - StartPosition).magnitude > DownloadDistance)
      {
          OnPositionChanged();
          StartPosition = positionBefore;
      }

      if (isMoving) {
        float speed = Mathf.Clamp(transform.position.y, MovementSpeed * 0.01f, MovementSpeed);
        Vector3 forward = Quaternion.Euler(0, Azimuth, 0) * Vector3.forward;
        Vector3 right = Quaternion.Euler(0, Azimuth, 0) * Vector3.right;

        Vector3 motion =
            (forward * xInput + right * zInput) * speed * Time.deltaTime;
        Vector3 position = transform.position + motion;

        position.y = Mathf.Clamp(position.y, MinHeight, MaxHeight);
        transform.position = position;
      }
      
      if (isRotating) {
        Azimuth += rotY * RotationSpeed * Time.deltaTime;

        Inclination = Mathf.Clamp(
            Inclination + rotX * RotationSpeed * Time.deltaTime, MinXRotation, MaxXRotation);
        
        transform.localRotation = Quaternion.Euler(Inclination, Azimuth, 0);
      }
      
      // Invoke any defined Actions to inform other classes of any change in Camera's movement or
      // rotation this frame.
      if (isMoving) {
        // Pass in the amount moved this frame (current position minus position last frame).
        OnMove.Invoke(transform.position - positionBefore);
      }

      if (isRotating) {
        OnRotate.Invoke();
      }

      OnTransform.Invoke();
    }
  }
}
