using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class TutorialGameManager : GameManager
{
    public override void AddPoints(int pointsToAdd)
    {
        base.AddPoints(pointsToAdd);
        MMDebug.DebugLogTime("new gamemanager add point");
        Triggerfireworks();
    }

    protected virtual void Triggerfireworks()
    {
        
    }
}
