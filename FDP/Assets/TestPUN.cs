using UnityEngine;
public class TestPUN : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Instantiating CUBE");
            
        }
    }
}
