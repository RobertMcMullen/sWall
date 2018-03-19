using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchZoom : MonoBehaviour
{
	//After viewing the game on the big screen, the pinch zoom should not be used and is not required.
    public float perspectiveZoomSpeed = 10f;
    public float orthoZoomSpeed = 10f;
    public Camera cam;

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudediff = prevTouchDeltaMag - touchDeltaMag;

            if (cam.orthographic)
            {
                cam.orthographicSize += deltaMagnitudediff * orthoZoomSpeed;
                cam.orthographicSize = Mathf.Max(cam.orthographicSize, .1f);
            }
            else
            {
                cam.fieldOfView += deltaMagnitudediff * perspectiveZoomSpeed;
                cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, .1f, 179.9f);
            }
        }
    }
}
