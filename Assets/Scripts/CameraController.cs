using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] internal float speed;
    [SerializeField] internal float SensitivityX, SensitivityY;
         
    private void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
           0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        float horizontal = Input.GetAxis("Mouse X") * SensitivityX;
        float vertical = Input.GetAxis("Mouse Y") * -SensitivityY;
        transform.rotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x + vertical,
            transform.eulerAngles.y + horizontal, transform.eulerAngles.z));
    }
}
