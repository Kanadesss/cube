using UnityEngine;

public class CubeKeyboardContoller : MonoBehaviour {
  [SerializeField] private CubeMovement cubeMovement;
  [SerializeField] private Camera cameraCurrent;

  private void FixedUpdate() {

    if (Input.GetKey(KeyCode.W)) {
      Vector3 rotatiotnAxis = cameraCurrent.transform.right;
      cubeMovement.Move(rotatiotnAxis);
    } else if (Input.GetKey(KeyCode.S)) {
      Vector3 rotatiotnAxis = cameraCurrent.transform.right * -1;
      cubeMovement.Move(rotatiotnAxis);
    }

  }
}
