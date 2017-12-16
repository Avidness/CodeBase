using System;
using System.Linq;

namespace CodeBaseWeb.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CodeToolsContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}