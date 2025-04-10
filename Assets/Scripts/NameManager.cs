using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    public static NameManager Instance;
    public string PlayerName;
    
    
    void Awake()
    {
         PlayerName = "Enter Name";
    
        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this; 
        DontDestroyOnLoad(gameObject);

    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
       
    }

    public string getPlayerName(){ 
        return PlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerNameChange(string name)
    {
        PlayerName = name;
    }

}
