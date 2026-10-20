// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferMandateData1ValidatorTests
{
    private readonly CreditTransferMandateData1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ICreditTransferMandateData1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ICreditTransferMandateData1>(b => b
            .Set(x => x.MandateIdentification).To("MNDT-001")
            .Set(x => x.Type).To(IsoDataFactory.Make<IMandateTypeInformation2>())
            .Set(x => x.DateOfSignature).To(new DateOnly(2026, 1, 1))
            .Set(x => x.DateOfVerification).To(new DateTime(2026, 1, 1))
            .Set(x => x.ElectronicSignature).To(Convert.ToBase64String([1, 2, 3]))
            .Set(x => x.FirstPaymentDate).To(new DateOnly(2026, 2, 1))
            .Set(x => x.FinalPaymentDate).To(new DateOnly(2026, 12, 1))
            .Set(x => x.Frequency).To(IsoDataFactory.Make<Choices.Frequency36Choice.IType>(b2 => b2
                .Set(x2 => x2.Value).To(Frequency6Code.Monthly)))
            .Set(x => x.Reason).To(IsoDataFactory.Make<Choices.MandateSetupReason1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYREASON"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
