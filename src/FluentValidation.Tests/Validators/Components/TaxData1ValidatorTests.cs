// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxData1ValidatorTests
{
    private readonly TaxData1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ITaxData1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ITaxData1>(b => b
            .Set(x => x.Creditor).To(IsoDataFactory.Make<ITaxParty1>(b2 => b2
                .Set(x2 => x2.TaxIdentification).To("TAX-C-001")))
            .Set(x => x.Debtor).To(IsoDataFactory.Make<ITaxParty2>(b2 => b2
                .Set(x2 => x2.TaxIdentification).To("TAX-D-001")))
            .Set(x => x.UltimateDebtor).To(IsoDataFactory.Make<ITaxParty2>(b2 => b2
                .Set(x2 => x2.TaxIdentification).To("TAX-UD-001")))
            .Set(x => x.AdministrationZone).To("Zone1")
            .Set(x => x.ReferenceNumber).To("REF-001")
            .Set(x => x.Method).To("Direct")
            .Set(x => x.TotalTaxableBaseAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 1000m })
            .Set(x => x.TotalTaxAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 55m })
            .Set(x => x.Date).To(new DateOnly(2026, 1, 1))
            .Set(x => x.SequenceNumber).To(1)
            .Set(x => x.Record).To([IsoDataFactory.Make<ITaxRecord3>(b2 => b2
                .Set(x2 => x2.Type).To("VAT"))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
