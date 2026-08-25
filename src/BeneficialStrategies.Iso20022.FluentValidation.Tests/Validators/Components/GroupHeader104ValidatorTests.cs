// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader104ValidatorTests
{
    private readonly GroupHeader104Validator _sut = new();

    private static GroupHeader104 ValidMessage() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfSettlementRequests = "1",
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ControlSum_Present_NoValidationError()
    {
        var msg = ValidMessage() with { ControlSum = 100.00m };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SettlementInformation = new SettlementInstruction14
            {
                SettlementMethod = SettlementMethod2Code.ClearingSystem,
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
