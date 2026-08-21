// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferMandateData1ValidatorTests
{
    private readonly CreditTransferMandateData1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new CreditTransferMandateData1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new CreditTransferMandateData1
        {
            MandateIdentification = "MNDT-001",
            Type = new MandateTypeInformation2(),
            DateOfSignature = new DateOnly(2026, 1, 1),
            DateOfVerification = new DateTime(2026, 1, 1),
            ElectronicSignature = Convert.ToBase64String([1, 2, 3]),
            FirstPaymentDate = new DateOnly(2026, 2, 1),
            FinalPaymentDate = new DateOnly(2026, 12, 1),
            Frequency = new BeneficialStrategies.Iso20022.Choices.Frequency36Choice.Type
            {
                Value = Frequency6Code.Monthly,
            },
            Reason = new BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice.Proprietary
            {
                Value = "MYREASON",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
