using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGun : MonoBehaviour
{
  public Camera playerCamera;
  public Transform laserOrigin;
  public float gunRange = 50f;

  void Update()
  {
      Vector3 rayOrigin = playerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
      RaycastHit hit;
      if (Physics.Raycast(rayOrigin, playerCamera.transform.forward, out hit, gunRange))
      {
        Destroy(hit.transform.gameObject);
      }
  }
}