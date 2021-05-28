using System;
using Shouldly;
using Xunit;

namespace Books.Catalog.Api.UnitTests
{
    public class ProgramTests
    {
        [Fact]
        public void CreateHostBuilder_WhenCalled_ThenCreatesHostWithoutExceptions()
            => Should.NotThrow(() => Program.CreateHostBuilder(Array.Empty<string>()));
    }
}
