using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;

namespace LearnOpenTK
{
    class Program
    {
        private static void Main()
        {
            var nativeWindowSettings = new NativeWindowSettings()
            {
                Size = new Vector2i(800, 600),
                Title = "LearnOpenTK - Shaders Uniforms!",
                Flags = OpenTK.Windowing.Common.ContextFlags.ForwardCompatible,
            };

            using (var window = new Window(GameWindowSettings.Default, nativeWindowSettings))
            {
                window.Run();
            }
        }
    }
}
