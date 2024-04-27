using UnityEngine;

namespace LiteNinja.MonoActions
{
    public class DelayedExecutor : MonoBehaviour
    {
        [Header("Execute on Delay")]
        [SerializeField] private BaseMonoAction[] _delayedActions;
        
        [Header("Delay")]
        [SerializeField] private float _delay = 1f;
        
        private void Start()
        {
            Invoke(nameof(ExecuteDelayedActions), _delay);
        }
        
        private void ExecuteDelayedActions()
        {
            foreach (var action in _delayedActions)
            {
                action.Execute();
            }
        }
    }
}