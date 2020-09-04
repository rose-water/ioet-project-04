using System.Collections;
using UnityEngine;

public class GateRotateScript : MonoBehaviour {
  private float turnSpeed = 1.0f;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
  }
}
