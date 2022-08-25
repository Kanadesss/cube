using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CubeMovement : MonoBehaviour {

  private static float maxAngularVelocity = 5.5f;   // 5.5 - ���������� �����, ������������ ��� 0.5 <= Scale <= 4

  private Rigidbody _rigidbody;
  private float rotationSpeed;

  void Awake() {
    _rigidbody = GetComponent<Rigidbody>();
  }

  void OnEnable() {
    SetMaxAngularVelocity();
  }

  public void Move(Vector3 rotatiotnAxis) {
    _rigidbody.AddTorque(rotatiotnAxis * rotationSpeed, ForceMode.VelocityChange);
  }

  private void SetMaxAngularVelocity() {
    _rigidbody.maxAngularVelocity = Mathf.Abs(maxAngularVelocity - transform.localScale.x);
    rotationSpeed = _rigidbody.maxAngularVelocity;
  }

}
