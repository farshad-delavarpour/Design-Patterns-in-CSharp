namespace DesignPatterns.Decorator.Example2
{
    public class MainDecorator : IArtefact
    {
        private IArtefact _artefact;

        public MainDecorator(IArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            return _artefact.Render() + " [Main]";
        }
    }
}