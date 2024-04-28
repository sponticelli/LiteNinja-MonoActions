namespace LiteNinja.MonoActions
{
    /// <summary>
    /// It destroys the GameObject that this component is attached to.
    /// </summary>
    public class DestroyGameObjectAction : BaseMonoAction
    {
        public override void Execute()
        {
            Destroy(gameObject);
        }
    }
}