using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PublicLabFactors;


public class GlobalMemory : MonoBehaviour
{
    public static GlobalMemory Instance;

    public ServerController server;
    public demoDataMemory demoData;

    [HideInInspector]
    public string serverip;
    [HideInInspector]
    public ServerCommand curServerCommand;
    [HideInInspector]
    public LabScene curServerScene, curClientScene;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
