// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class DeleteStandingOrderV05ValidatorTests
{
    private readonly DeleteStandingOrderV05Validator _sut = new();

    private static MessageHeader1 ValidMessageHeader() => new() { MessageIdentification = "MSG-001" };

    private static BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice_ ValidStandingOrderDetails() =>
        new BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice.StandingOrder
        {
            Value = new StandingOrderIdentification8
            {
                Account = new CashAccount40
                {
                    Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                    {
                        Value = "DE89370400440532013000",
                    },
                },
            },
        };

    private static DeleteStandingOrderV05 ValidMessage() =>
        new() { MessageHeader = ValidMessageHeader(), StandingOrderDetails = ValidStandingOrderDetails() };

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
