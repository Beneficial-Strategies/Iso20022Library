// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RestrictedFINExact2TextTests : SimpleValueStringContractTests<RestrictedFINExact2Text>
{
    protected override string ValidSample => "XX";
    protected override string InvalidSample => "YY";

    [Fact] public void ValueXX_IsAccepted() => Assert.NotNull(Activator.CreateInstance(typeof(RestrictedFINExact2Text), "XX"));
    [Fact] public void ValueTS_IsAccepted() => Assert.NotNull(Activator.CreateInstance(typeof(RestrictedFINExact2Text), "TS"));

    [Fact]
    public void AnyOtherValue_ThrowsPatternMismatch()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => Activator.CreateInstance(typeof(RestrictedFINExact2Text), "AB"));
        Assert.Equal(Iso20022FormatViolation.PatternMismatch, Assert.IsType<Iso20022FormatException>(ex.InnerException).Violation);
    }
}
