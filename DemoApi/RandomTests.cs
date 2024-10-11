using FluentAssertions;
using Xunit;

namespace DemoApi;

public class RandomTests
{
    [Fact]
    public void ThisTestShouldPass()
    {
        // Arrange
        var value = "NotMyName";
        var result = "Tim";
        // Act
        var test = value.TransformToMyName();

        // Assert
        test.Should().Be(result);
    }
}