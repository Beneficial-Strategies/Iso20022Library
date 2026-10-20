// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateRelatedInformation16ValidatorTests
{
    private readonly MandateRelatedInformation16Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IMandateRelatedInformation16>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IMandateRelatedInformation16>(b => b
            .Set(x => x.AmendmentIndicator).To(true)
            .Set(x => x.AmendmentInformationDetails).To(IsoDataFactory.Make<IAmendmentInformationDetails15>())
            .Set(x => x.DateOfSignature).To(new DateOnly(2026, 1, 1))
            .Set(x => x.ElectronicSignature).To(Convert.ToBase64String([1, 2, 3]))
            .Set(x => x.FinalCollectionDate).To(new DateOnly(2026, 12, 1))
            .Set(x => x.FirstCollectionDate).To(new DateOnly(2026, 2, 1))
            .Set(x => x.Frequency).To(IsoDataFactory.Make<Choices.Frequency36Choice.IType>(b2 => b2
                .Set(x2 => x2.Value).To(Frequency6Code.Monthly)))
            .Set(x => x.MandateIdentification).To("MNDT-001")
            .Set(x => x.Reason).To(IsoDataFactory.Make<Choices.MandateSetupReason1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYREASON")))
            .Set(x => x.TrackingDays).To("05"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
