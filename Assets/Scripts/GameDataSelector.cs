using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDataSelector : MonoBehaviour
{
    public GameData currentGameData;
    public GameLevelData levelData;
    void Start()
    {
        
    }

    private void SelectSequentialBoardData()
    {
        foreach (var data in levelData.data)
        {
            if (data.categoryName == currentGameData.selectedCategoryName)
            {
                var boardIndex = 0; 

                if(boardIndex < data.boardData.Count)
                {
                    currentGameData.selectedBoardData = data.boardData[boardIndex];
                }
                else 
                {
                    var randomIndex = Random.Range(0 ,data.boardData.Count);
                    currentGameData.selectedBoardData = data.boardData[randomIndex];
                }
                
            }
        }
    }
}
