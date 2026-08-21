// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class CreateLimitV02ValidatorTests
{
    private readonly CreateLimitV02Validator _sut = new();

    private static MessageHeader1 ValidMessageHeader() => new() { MessageIdentification = "MSG-001" };

    private static CreateLimitV02 ValidMessage() => new() { MessageHeader = ValidMessageHeader() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void LimitData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            LimitData =
            [
                new LimitStructure6
                {
                    LimitIdentification = new LimitIdentification8
                    {
                        Type = new BeneficialStrategies.Iso20022.Choices.LimitType1Choice.Code
                        {
                            Value = LimitType3Code.Bilateral,
                        },
                    },
                    Amount = new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithCurrency
                    {
                        Currency = "USD",
                        Amount = 100m,
                    },
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
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
