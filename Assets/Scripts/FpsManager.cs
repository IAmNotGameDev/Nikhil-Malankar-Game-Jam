using UnityEngine;

public class FPSManager : MonoBehaviour
{
    [SerializeField]
    private int targetFrameRate = 60;

    private static FPSManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            ApplyFPSSettings();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void ApplyFPSSettings()
    {
        Application.targetFrameRate = targetFrameRate;

    }
}