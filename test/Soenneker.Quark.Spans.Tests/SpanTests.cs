using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Spans.Tests;

[Collection("Collection")]
public sealed class SpanTests : FixturedUnitTest
{
    public SpanTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
