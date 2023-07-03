using UnityEngine;

public class UpdatePlayerPosition : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        Shader.SetGlobalVector("_Player_Position", transform.position);
    }
}
