// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class RequestType4Choice_ValidatorTests
{
    private readonly RequestType4Choice_Validator _sut = new();

    [Fact]
    public void PaymentControlVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.RequestType4Choice.IPaymentControl>(b => b
            .Set(x => x.Value).To(ExternalPaymentControlRequestType1Code.ReleasePending));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EnquiryVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.RequestType4Choice.IEnquiry>(b => b
            .Set(x => x.Value).To(ExternalEnquiryRequestType1Code.BankPositionEnquiry));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.RequestType4Choice.IProprietary>(b => b
            .Set(x => x.Identification).To("REQ-TYPE-001"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
