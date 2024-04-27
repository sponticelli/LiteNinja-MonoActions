using UnityEngine;

namespace LiteNinja.MonoActions
{
    public class MonoExecutor : MonoBehaviour
    {
        [Header("Execute on Awake")]
        [SerializeField] private BaseMonoAction[] _awakeActions;
        
        [Header("Execute on OnEnable")]
        [SerializeField] private BaseMonoAction[] _onEnableActions;
        
        [Header("Execute on Start")]
        [SerializeField] private BaseMonoAction[] _startActions;
        
        
        private void Awake()
        {
            foreach (var action in _awakeActions)
            {
                action.Execute();
            }
        }
        
        private void OnEnable()
        {
            foreach (var action in _onEnableActions)
            {
                action.Execute();
            }
        }
        
        private void Start()
        {
            foreach (var action in _startActions)
            {
                action.Execute();
            }
        }
        
    }
}