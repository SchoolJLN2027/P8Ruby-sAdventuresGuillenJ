using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.y = position.y + 0.1f * vertical;
        position.x = position.x + 0.1f * horizontal;
        transform.position = position;

    }
}
