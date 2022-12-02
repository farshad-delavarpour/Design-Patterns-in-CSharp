using DesignPatterns.State;

namespace DesignPatterns.BrushTool
{
    public class BrushTool : ITool
    {
        public string MouseDown() => "Brush Mouse Down";
        public string MouseUp() => "Brush Mouse Up";
    }

    public class EraserTool : ITool
    {
        public string MouseDown() => "Eraser Mouse Down";
        public string MouseUp() => "Eraser Mouse Up";
    }
}