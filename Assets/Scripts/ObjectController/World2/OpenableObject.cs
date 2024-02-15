using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OpenableObject : MonoBehaviour
{
    public bool isOpened = false;

    [Tooltip("Shows if door is locked")]
    public bool isLocked = true;

    //conditions are intendet to be object ids
    private List<int> openConditions = new List<int>();
    private List<int> unlockConditions = new List<int>();

    //Used to mark a OpenCondition a done/not done and open if all are met / close if not
    public void toggleOpenCondition(int condition)  
    {
        if (openConditions.Contains(condition))
        {
            openConditions.Remove(condition);
        }
        else
        {
            openConditions.Add(condition);
        }
        
        if(openConditions.Count == 0 && !isOpened) 
        {
            open();
        }
        else if(isOpened)
        {
            close();
        }
    }

    //Used to mark a UnlockCondition a done / not done and unlock if all are met / lock if not
    public void toggleUnlockCondition(int condition)
    {
        if (unlockConditions.Contains(condition))
        {
            unlockConditions.Remove(condition);
        }
        else
        {
            unlockConditions.Add(condition);
        }
        if (unlockConditions.Count == 0)
        {
            isLocked = false;
        }
        else if (isLocked)
        {
            isLocked = true;
        }
    }

    public void open()
    {
        openObject();
        isOpened = true;
    }

    public void close()
    {
        closeObject();
        isOpened = false;
    }

    //toggles between open and close / isOpend
    public void action()   
    {
        if (isOpened)
        {
            close();
        }
        else
        {
            open();
        }
    }

    //functions to open / close the specific derived class
    protected abstract void openObject();
    protected abstract void closeObject();

    protected void OnCollisionEnter(Collision collision)
    {
        if (!isLocked)
        {
            action();
        }
    }
}
