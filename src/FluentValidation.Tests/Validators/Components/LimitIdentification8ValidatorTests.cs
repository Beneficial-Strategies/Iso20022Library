// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class LimitIdentification8ValidatorTests
{
    private readonly LimitIdentification8Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.LimitType1Choice_ ValidType() =>
        new BeneficialStrategies.Iso20022.Choices.LimitType1Choice.Code { Value = LimitType3Code.Bilateral };

    private static LimitIdentification8 ValidMessage() => new() { Type = ValidType() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
        };
        var msg = ValidMessage() with
        {
            AccountIdentification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
            AccountOwner = agent,
            BilateralLimitCounterpartyIdentification = agent,
            SystemIdentification = new BeneficialStrategies.Iso20022.Choices.SystemIdentification2Choice.Country
            {
                Value = "DE",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
