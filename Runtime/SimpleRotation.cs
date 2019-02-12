using UnityEngine;

class SimpleRotation_gh : MonoBehaviour
{
    public float angularVelocity = 10;

    void Update()
    {
        var rot = Quaternion.AngleAxis(angularVelocity * Time.deltaTime, Vector3.up);
        transform.localRotation = rot * transform.localRotation;
		Debug.Log ("ffff");
    }
}
