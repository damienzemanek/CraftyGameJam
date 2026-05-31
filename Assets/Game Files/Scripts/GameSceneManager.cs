using System;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : Singleton<GameSceneManager>
{
    public enum Scenes
    {
        Menu,
        Intro,
        Level1,
        Win
    }
    
    
    [Serializable]
    public struct SceneData
    {
        public Scenes scene;
        public int level;
    }
    
    [SerializeField] public List<SceneData> sceneData;

    public int GetScene(Scenes scene) => sceneData.FindIndex(s => s.scene == scene);
}