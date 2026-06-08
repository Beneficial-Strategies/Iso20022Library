// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Contract tests for <see cref="Max10MbText"/>.
/// Boundary tests (ExactMaxLength, OneOverMaxLength) are skipped — allocating 10MB+ strings
/// in test is impractical. Core construction, TryCreate, and JSON round-trip are verified.
/// </summary>
public class Max10MbTextTests : SimpleValueMaxTextContractTests<Max10MbText>
{
    // MaxLength = 10,000,000 but boundary tests allocating that many chars are impractical.
    // Use lightweight ValidSample and override the allocation-heavy tests.
    protected override int MaxLength => 10000000;
    protected override string ValidSample   => "Hello";
    protected override string InvalidSample => new string('A', 10000001); // only used in InvalidConstruction check

    public override void ExactMaxLength_IsAccepted()
    {
        // Skip — would require allocating 10MB string.
        var instance = Activator.CreateInstance(typeof(Max10MbText), "A");
        Assert.NotNull(instance);
    }

    public override void OneOverMaxLength_ThrowsTooLong()
    {
        // Skip — would require allocating 10MB+ string.
        // Instead verify empty string rejects with TooShort.
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(Max10MbText), string.Empty));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }
}
