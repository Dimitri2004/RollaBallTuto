using UnityEngine;

public class Rotador : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //Rotation onli in z axis
        transform.Rotate(0, 0, 100 * Time.deltaTime);
    }
}
