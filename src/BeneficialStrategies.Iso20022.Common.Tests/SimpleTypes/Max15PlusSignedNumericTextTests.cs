// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max15PlusSignedNumericTextTests : SimpleValueMaxTextContractTests<Max15PlusSignedNumericText>
{
    protected override int MaxLength => 16;
    // The '+' prefix makes single-char padding useless — provide explicit samples.
    protected override string ValidSample => "+12345";
    protected override string InvalidSample => new string('X', 17); // invalid char + too long

    // Override boundary tests: a single-char pad can't produce a valid 16-char value for this type.
    // Valid max-length form is '+' followed by exactly 15 digits.
    public override void ExactMaxLength_IsAccepted()
    {
        var instance = Activator.CreateInstance(typeof(Max15PlusSignedNumericText), "+111111111111111");
        Assert.NotNull(instance);
    }

    public override void OneOverMaxLength_ThrowsTooLong()
    {
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(Max15PlusSignedNumericText), "+1111111111111111")); // 17 chars
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }
}
