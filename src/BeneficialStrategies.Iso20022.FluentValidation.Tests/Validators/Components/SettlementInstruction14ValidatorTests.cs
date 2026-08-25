// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SettlementInstruction14ValidatorTests
{
    private readonly SettlementInstruction14Validator _sut = new();

    private static SettlementInstruction14 ValidMessage() =>
        new() { SettlementMethod = SettlementMethod2Code.ClearingSystem };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementAccount_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SettlementAccount = new CashAccount40
            {
                Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ClearingSystem_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ClearingSystem = new BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification3Choice.Code
            {
                Value = ExternalCashClearingSystem1Code.Target,
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
