﻿using RollingRush.Core;
using UnityEngine;

namespace RollingRush.UI
{
    public class InGamePanelManager : MonoBehaviour
    {
        [SerializeField] protected GameObject panel;
    
        public virtual void ResetLevel()
        {
            Time.timeScale = 1f;
            panel.SetActive(false);
            LevelLoadingManager.Instance.LoadLevel(LevelLoadingManager.Instance.CurrentLevelIndex);
        }
    
        public void BackToMainMenu()
        {
            Time.timeScale = 1f;
            LevelLoadingManager.Instance.LoadLevel("Main Menu");
        }
    }
}
