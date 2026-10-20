// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class DeleteLimitV08ValidatorTests
{
    private readonly DeleteLimitV08Validator _sut = new();

    private static MessageHeader1 ValidMessageHeader() => new() { MessageIdentification = "MSG-001" };

    private static BeneficialStrategies.Iso20022.Choices.LimitStructure3Choice_ ValidLimitDetails() =>
        new BeneficialStrategies.Iso20022.Choices.LimitStructure3Choice.CurrentLimitIdentification
        {
            Value = new LimitIdentification8
            {
                Type = new BeneficialStrategies.Iso20022.Choices.LimitType1Choice.Code
                {
                    Value = LimitType3Code.Bilateral,
                },
            },
        };

    private static DeleteLimitV08 ValidMessage() =>
        new() { MessageHeader = ValidMessageHeader(), LimitDetails = ValidLimitDetails() };

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
