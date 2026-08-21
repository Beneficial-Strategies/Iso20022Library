// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTypeInformation28ValidatorTests
{
    private readonly PaymentTypeInformation28Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new PaymentTypeInformation28()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new PaymentTypeInformation28
        {
            InstructionPriority = Priority2Code.High,
            ClearingChannel = ClearingChannel2Code.RealTimeGrossSettlementSystem,
            ServiceLevel =
            [
                new BeneficialStrategies.Iso20022.Choices.ServiceLevel8Choice.Proprietary { Value = "SEPA" },
            ],
            LocalInstrument = new BeneficialStrategies.Iso20022.Choices.LocalInstrument2Choice.Proprietary
            {
                Value = "INST",
            },
            CategoryPurpose = new BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice.Proprietary
            {
                Value = "CASH",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
