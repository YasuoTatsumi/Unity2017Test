using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    Camera m_camera;

    public float m_x_aspect = 16.0f;
    public float m_y_aspect = 9.0f;
    float m_target_aspect = 1;
    float m_temp_window_aspect = 1.0f;

    void Awake()
    {
        m_target_aspect = m_x_aspect / m_y_aspect;
        calcAspect();
    }

    void Update()
    {
        calcAspect();
    }

    private void calcAspect()
    {
        float window_aspect = (float)Screen.width / (float)Screen.height;

        if(m_temp_window_aspect != window_aspect)
        {
            float scale_height = window_aspect / m_target_aspect;

            Rect rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

            if(1.0f > scale_height)
            {
                rect.x = 0;
                rect.y = (1.0f - scale_height) / 2.0f;
                rect.width = 1.0f;
                rect.height = scale_height;
            }
            else
            {
                float scale_width = 1.0f / scale_height;
                rect.x = (1.0f - scale_width) / 2.0f;
                rect.y = 0.0f;
                rect.width = scale_width;
                rect.height = 1.0f;
            }

            m_camera.rect = rect;
            m_temp_window_aspect = window_aspect;
        }
    }
}
