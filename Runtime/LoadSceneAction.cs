using UnityEngine;
using UnityEngine.SceneManagement;

namespace LiteNinja.MonoActions
{
    public class LoadSceneAction : BaseMonoAction
    {
        [SerializeField] private string _sceneName;
        [SerializeField] private LoadSceneMode _loadSceneMode = LoadSceneMode.Single;
        
        
        public override void Execute()
        {
            SceneManager.LoadScene(_sceneName, _loadSceneMode);
        }
    }
}