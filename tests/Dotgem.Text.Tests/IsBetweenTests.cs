namespace Dotgem.Text.Tests;

public class IsBetweenTests
{
    [Fact]
    public void CharWithChar()
    {
        Assert.True('4'.IsBetween('0', '9'));
        Assert.False('5'.IsBetween('a', 'z'));
        Assert.False('`'.IsBetween('a', 'z'));
        Assert.False('{'.IsBetween('a', 'z'));
        Assert.True('r'.IsBetween('a', 'z'));
        Assert.True('a'.IsBetween('a', 'z'));
        Assert.True('z'.IsBetween('a', 'z'));
    }

    [Fact]
    public void CharWithInt()
    {
        Assert.True('4'.IsBetween(48, 57));
        Assert.False('5'.IsBetween(97, 122));
        Assert.False('`'.IsBetween(97, 122));
        Assert.False('{'.IsBetween(97, 122));
        Assert.True('r'.IsBetween(97, 122));
        Assert.True('a'.IsBetween(97, 122));
        Assert.True('z'.IsBetween(97, 122));
    }

    [Fact]
    public void IntWithInt()
    {
        Assert.True(50.IsBetween(48, 57));
        Assert.False(5.IsBetween(97, 122));
        Assert.False(96.IsBetween(97, 122));
        Assert.False(123.IsBetween(97, 122));
        Assert.True(113.IsBetween(97, 122));
        Assert.True(122.IsBetween(97, 122));
        Assert.True(97.IsBetween(97, 122));
        Assert.False(500.IsBetween(-97, 122));
        Assert.False(960.IsBetween(-97, 122));
        Assert.False(123.IsBetween(-97, 122));
        Assert.True(113.IsBetween(-97, 122));
        Assert.True(122.IsBetween(-97, 122));
        Assert.True(97.IsBetween(-97, 122));
        Assert.False((-234).IsBetween(-97, 122));
        Assert.False((-98).IsBetween(-97, 122));
        Assert.False((-33).IsBetween(-97, -34));
        Assert.False((-98).IsBetween(-97, -34));
        Assert.True((-34).IsBetween(-97, -34));
        Assert.True((-97).IsBetween(-97, -34));
        Assert.True(0.IsBetween(-97, 122));
        Assert.True((-97).IsBetween(-97, 122));
        Assert.True((-53).IsBetween(-97, 122));
    }
}
