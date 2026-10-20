// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateRelatedInformation16ValidatorTests
{
    private readonly MandateRelatedInformation16Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new MandateRelatedInformation16()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new MandateRelatedInformation16
        {
            AmendmentIndicator = true,
            AmendmentInformationDetails = new AmendmentInformationDetails15(),
            DateOfSignature = new DateOnly(2026, 1, 1),
            ElectronicSignature = Convert.ToBase64String([1, 2, 3]),
            FinalCollectionDate = new DateOnly(2026, 12, 1),
            FirstCollectionDate = new DateOnly(2026, 2, 1),
            Frequency = new BeneficialStrategies.Iso20022.Choices.Frequency36Choice.Type
            {
                Value = Frequency6Code.Monthly,
            },
            MandateIdentification = "MNDT-001",
            Reason = new BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice.Proprietary
            {
                Value = "MYREASON",
            },
            TrackingDays = "05",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
