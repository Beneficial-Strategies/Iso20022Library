// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxRecord3ValidatorTests
{
    private readonly TaxRecord3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new TaxRecord3()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new TaxRecord3
        {
            Type = "VAT",
            Category = "CAT1",
            CategoryDetails = "Details",
            DebtorStatus = "Active",
            CertificateIdentification = "CERT-001",
            FormsCode = "FORM1",
            Period = new TaxPeriod3 { Year = 2026 },
            TaxAmount = new TaxAmount3 { Rate = 5.5m },
            AdditionalInformation = "Extra info",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
