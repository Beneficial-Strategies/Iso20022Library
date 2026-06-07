// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Exact1HexBinaryTextTests : SimpleValueMaxTextContractTests<Exact1HexBinaryText>
{
    protected override int MinLength => 2;
    protected override int MaxLength => 2;
    protected override string ValidSample   => "1A";
    protected override string InvalidSample => "GGG"; // invalid hex + wrong length

    [Fact]
    public void LowerCaseHex_ThrowsInvalidCharacter()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => Activator.CreateInstance(typeof(Exact1HexBinaryText), "1a"));
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, Assert.IsType<Iso20022FormatException>(ex.InnerException).Violation);
    }

    [Fact]
    public void ByteConstructor_ProducesUppercaseHex()
    {
        var instance = new Exact1HexBinaryText((byte)26);
        Assert.Equal("1A", instance.Value);
    }

    [Fact]
    public void ByteValue_RoundTrips()
    {
        var instance = new Exact1HexBinaryText((byte)255);
        Assert.Equal((byte)255, instance.ByteValue);
    }

    [Fact]
    public void ImplicitFromByte_Works()
    {
        Exact1HexBinaryText code = (byte)0x0F;
        Assert.Equal("0F", code.Value);
    }

    [Fact]
    public void EqualsByte_Compares_ByNumericValue()
    {
        var code = new Exact1HexBinaryText((byte)26);
        Assert.True(code == (byte)26);
        Assert.False(code == (byte)27);
    }
}
