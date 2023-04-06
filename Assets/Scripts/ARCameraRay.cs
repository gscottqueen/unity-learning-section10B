using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*[RequireComponent(typeof(LineRenderer))]*/
public class ARCameraRay : MonoBehaviour
{

  Camera arCamera;
  Vector3 pos = new Vector3(200, 400, 0);
  public AudioSource audioData;
  // Start is called before the first frame update
  void Start()
  {
    arCamera = GetComponent<Camera>();
/*    audioData = GetComponent<AudioSource>();*/
  }

  // Update is called once per frame
  void Update()
  {
    RaycastHit hit;
    Ray ray = arCamera.ScreenPointToRay(pos);
    Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
    if (Physics.Raycast(ray, out hit))
    {
      Transform objectHit = hit.transform;
      if (objectHit.tag == "Enemy")
      {
        audioData.Play(0);
        Destroy(hit.transform.gameObject);
      }
      Debug.Log(objectHit);
    }
  }
}