using UnityEngine;

namespace LiteNinja.MonoActions
{
    /// <summary>
    /// Destroy the GameObjects that are assigned to this component.
    /// </summary>
    public class DestroyGameObjectsAction : BaseMonoAction
    {
        [SerializeField]
        public GameObject[] gameObjects;
        
        public override void Execute()
        {
            foreach (var gameObject in gameObjects)
            {
                Destroy(gameObject);
            }
        }
    }
}