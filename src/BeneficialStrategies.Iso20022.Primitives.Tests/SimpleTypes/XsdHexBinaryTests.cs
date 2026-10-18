// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdHexBinaryTests : SimpleValueStringContractTests<XsdHexBinary>
{
    protected override string ValidSample => "1A2B";
    protected override string InvalidSample => "1a2b"; // lowercase not accepted — canonical form is uppercase

    [Fact]
    public void BytesProperty_DecodesHexString()
    {
        var instance = new XsdHexBinary("1A2B");
        Assert.Equal([0x1A, 0x2B], instance.Bytes);
    }

    [Fact]
    public void ByteArrayConstructor_EncodesAsUppercaseHex()
    {
        var instance = new XsdHexBinary(new byte[] { 0x1A, 0x2B });
        Assert.Equal("1A2B", instance.Value);
    }

    [Fact]
    public void EmptyString_IsValid()
    {
        var instance = new XsdHexBinary("");
        Assert.Empty(instance.Bytes);
    }

    [Fact]
    public void OddLengthHexString_ThrowsFormatException()
    {
        var ex = Assert.Throws<Iso20022FormatException>(() => new XsdHexBinary("1A2"));
        Assert.NotNull(ex);
    }
}
