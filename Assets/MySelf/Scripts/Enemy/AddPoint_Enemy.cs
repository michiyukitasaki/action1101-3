using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class AddPoint_Enemy : MonoBehaviour
{
    //public int points = 10;

    public PlayerStatus playerStatus = new PlayerStatus();
    
    
    private void Start()
    {
        
        playerStatus = (PlayerStatus)MMSaveLoadManager.Load(typeof(PlayerStatus), PlayerStatus.FileName, "Assets/MySelf/Scripts/Enemy/SaveDataObj");

        if (playerStatus != null)
        {
            
            //セーブデータがあるときだけロード
            CorgiEnginePointsEvent.Trigger(PointsMethods.Set, playerStatus.points);
        }
        
    }



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            CheckSaveData();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            LoadSaveData();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            DeleteSaveData();
        }
        else if(Input.GetKeyDown(KeyCode.K))
        {
            SaveData();
        }

    }

    public void addPointEnemy(int points)
    {
        playerStatus.attackLevel += 3;
        playerStatus.attack += 30;
        playerStatus.points += 10;

        //GameManager.Instance.AddPoints(points);
        CorgiEnginePointsEvent.Trigger(PointsMethods.Add, points);
        
    }

    public void CheckSaveData()
    {
        Debug.Log("level :" + playerStatus.attackLevel.ToString());
        Debug.Log("attack :" + playerStatus.attack.ToString());
        Debug.Log("points :" + playerStatus.points.ToString());
    }

    public void LoadSaveData()
    {
        
        playerStatus = (PlayerStatus)MMSaveLoadManager.Load(typeof(PlayerStatus), PlayerStatus.FileName, "Assets/MySelf/Scripts/Enemy/SaveDataObj");
    }

    public void DeleteSaveData()
    {
        //playerStatus = (PlayerStatus)MMSaveLoadManager.Load(typeof(PlayerStatus), PlayerStatus.FileName, "Assets/MySelf/Scripts/Enemy/SaveDataObj");
        MMSaveLoadManager.DeleteSave(PlayerStatus.FileName, "Assets/MySelf/Scripts/Enemy/SaveDataObj");
    }
    public void SaveData()
    {
       MMSaveLoadManager.Save(playerStatus, PlayerStatus.FileName, "Assets/MySelf/Scripts/Enemy/SaveDataObj");
    }
}
