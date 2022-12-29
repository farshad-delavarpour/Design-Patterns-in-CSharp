namespace DesignPatterns.Decorator.Example2
{
    public class Editor
    {
        public void OpenProject()
        {
            List<IArtefact> artefacts = new()
            {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
            };

            artefacts[0] = new ErrorDecorator(new MainDecorator(artefacts[0]));
            artefacts[2] = new ErrorDecorator(artefacts[2]);

            foreach (var artefact in artefacts)
                System.Console.WriteLine(artefact.Render());
        }
    }
}