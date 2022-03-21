using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class cubeSpawner : MonoBehaviour
{
    internal InputField spawnSpeedInputField;
    [SerializeField] internal GameObject spawnSpeedInputFieldGO;
    [SerializeField] internal Transform cube;
    [SerializeField] internal float spawnSpeed;
    
    
    private void Start() {
        StartCoroutine(Spawn());
        spawnSpeedInputField = spawnSpeedInputFieldGO.GetComponent<InputField>();
    }

    private void Update() {
        spawnSpeed = float.Parse(spawnSpeedInputField.text);
    }

    private IEnumerator Spawn() {
        while (true) {
            Transform _cube = Instantiate(cube, this.gameObject.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1 / spawnSpeed);
        }
    }
}
