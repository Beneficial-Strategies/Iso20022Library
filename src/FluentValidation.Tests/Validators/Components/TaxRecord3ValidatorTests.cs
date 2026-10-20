// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxRecord3ValidatorTests
{
    private readonly TaxRecord3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ITaxRecord3>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ITaxRecord3>(b => b
            .Set(x => x.Type).To("VAT")
            .Set(x => x.Category).To("CAT1")
            .Set(x => x.CategoryDetails).To("Details")
            .Set(x => x.DebtorStatus).To("Active")
            .Set(x => x.CertificateIdentification).To("CERT-001")
            .Set(x => x.FormsCode).To("FORM1")
            .Set(x => x.Period).To(IsoDataFactory.Make<ITaxPeriod3>(b2 => b2
                .Set(x2 => x2.Year).To(2026)))
            .Set(x => x.TaxAmount).To(IsoDataFactory.Make<ITaxAmount3>(b2 => b2
                .Set(x2 => x2.Rate).To(5.5m)))
            .Set(x => x.AdditionalInformation).To("Extra info"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
