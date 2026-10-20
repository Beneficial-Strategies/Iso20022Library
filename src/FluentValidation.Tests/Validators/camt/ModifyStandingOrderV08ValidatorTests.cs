// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class ModifyStandingOrderV08ValidatorTests
{
    private readonly ModifyStandingOrderV08Validator _sut = new();

    private static MessageHeader1 ValidMessageHeader() => new() { MessageIdentification = "MSG-001" };

    private static StandingOrderIdentification8 ValidStandingOrderIdentification() =>
        new()
        {
            Account = new CashAccount40
            {
                Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
            },
        };

    private static ModifyStandingOrderV08 ValidMessage() =>
        new()
        {
            MessageHeader = ValidMessageHeader(),
            StandingOrderIdentification = ValidStandingOrderIdentification(),
            NewStandingOrderValueSet = new StandingOrder10(),
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
