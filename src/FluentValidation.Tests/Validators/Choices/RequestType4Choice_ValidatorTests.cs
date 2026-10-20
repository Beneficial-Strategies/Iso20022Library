// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class RequestType4Choice_ValidatorTests
{
    private readonly RequestType4Choice_Validator _sut = new();

    [Fact]
    public void PaymentControlVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.RequestType4Choice.PaymentControl
        {
            Value = ExternalPaymentControlRequestType1Code.ReleasePending,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EnquiryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.RequestType4Choice.Enquiry
        {
            Value = ExternalEnquiryRequestType1Code.BankPositionEnquiry,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.RequestType4Choice.Proprietary
        {
            Identification = "REQ-TYPE-001",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
