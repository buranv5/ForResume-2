using UnityEngine;
using UnityEngine.UI;

public class cubeMover : MonoBehaviour
{
    [SerializeField] public InputField speedInputField, distanceInputField;
    public float speed, distance;

    public void Start() {
        GameObject speedInputFieldGO = GameObject.Find("cubeSpeedInputField");
        speedInputField = speedInputFieldGO.GetComponent<InputField>();
        GameObject distanceInputFieldGO = GameObject.Find("distanceInputField");
        distanceInputField = distanceInputFieldGO.GetComponent<InputField>();
    }

    private void Update() {
        speed = float.Parse(speedInputField.text);
        distance = float.Parse(distanceInputField.text);
        if (transform.position.z < distance) {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        } else {
            Destroy(this.gameObject);
        }

    }
}
