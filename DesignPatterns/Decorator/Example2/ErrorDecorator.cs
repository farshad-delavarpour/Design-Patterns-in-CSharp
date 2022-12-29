namespace DesignPatterns.Decorator.Example2
{
    public class ErrorDecorator : IArtefact
    {
        private IArtefact _artefact;

        public ErrorDecorator(IArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            return _artefact.Render() + " [Error]";
        }
    }
}