
using System.Reflection;

namespace TestLib1
{
    public class TestClass
    {
        public TestClass() { }

        public string Version
        {
            get
            {
                Assembly? assembly = Assembly.GetAssembly(GetType());
                return assembly?.GetName().Version.ToString() ?? "Unknown Version";
            }
        }
    }
}


