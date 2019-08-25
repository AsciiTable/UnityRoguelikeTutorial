using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Make GameManager a Singleton (an Object in which there can only be one instance in the game at any given time)
    public static GameManager instance = null;


    public BoardManager boardScript;

    private int level = 3;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject); // keeps the GameManager alive even when the scene changes (scene changes destroys everything in the heirarchy otherwise) 
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }

    void InitGame() {
        boardScript.SetupScene(level);
    }

    void Update()
    {
        
    }
}
