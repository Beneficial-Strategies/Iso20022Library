// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class BranchAndFinancialInstitutionIdentification8ValidatorTests
{
    private readonly BranchAndFinancialInstitutionIdentification8Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidMessage() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void BranchIdentification_Present_NoValidationError()
    {
        var msg = ValidMessage() with { BranchIdentification = new BranchData5 { Name = "Main Branch" } };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
