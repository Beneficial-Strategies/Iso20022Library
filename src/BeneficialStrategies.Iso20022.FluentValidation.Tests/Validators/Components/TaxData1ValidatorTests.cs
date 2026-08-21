// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxData1ValidatorTests
{
    private readonly TaxData1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new TaxData1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new TaxData1
        {
            Creditor = new TaxParty1 { TaxIdentification = "TAX-C-001" },
            Debtor = new TaxParty2 { TaxIdentification = "TAX-D-001" },
            UltimateDebtor = new TaxParty2 { TaxIdentification = "TAX-UD-001" },
            AdministrationZone = "Zone1",
            ReferenceNumber = "REF-001",
            Method = "Direct",
            TotalTaxableBaseAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 1000m },
            TotalTaxAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 55m },
            Date = new DateOnly(2026, 1, 1),
            SequenceNumber = 1,
            Record = [new TaxRecord3 { Type = "VAT" }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
