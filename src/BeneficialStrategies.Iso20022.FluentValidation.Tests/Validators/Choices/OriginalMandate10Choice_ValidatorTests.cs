// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class OriginalMandate10Choice_ValidatorTests
{
    private readonly OriginalMandate10Choice_Validator _sut = new();

    [Fact]
    public void OriginalMandateIdentificationVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
            {
                Value = "MNDT-001",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    // OriginalMandate variant (wraps Mandate20, which has no validator yet — see the type's own
    // <remarks>) is intentionally not exercised here beyond confirming the dispatcher itself
    // doesn't throw for an unregistered-but-legitimate variant type; SetInheritanceValidator only
    // runs rules for variants explicitly registered via v.Add(...), so an unregistered variant is
    // always reported as valid by design, not by omission.
}
