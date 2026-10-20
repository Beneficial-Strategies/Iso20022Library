// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FinancialInstitutionDirectDebitV06ValidatorTests
{
    private readonly FinancialInstitutionDirectDebitV06Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static IGroupHeader119 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader119>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1"));

    private static IDirectDebitTransactionInformation33 ValidDirectDebitTransactionInformation() =>
        IsoDataFactory.Make<IDirectDebitTransactionInformation33>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.Debtor).To(ValidAgent("DEUTDEFFXXX"))
            .Set(x => x.InterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }));

    private static ICreditTransferTransaction66 ValidCreditInstruction() =>
        IsoDataFactory.Make<ICreditTransferTransaction66>(b => b
            .Set(x => x.CreditIdentification).To("CDT-001")
            .Set(x => x.Creditor).To(ValidAgent("BOFAUS3NXXX"))
            .Set(x => x.DirectDebitTransactionInformation).To([ValidDirectDebitTransactionInformation()]));

    private static IFinancialInstitutionDirectDebitV06 ValidMessage() =>
        IsoDataFactory.Make<IFinancialInstitutionDirectDebitV06>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.CreditInstruction).To([ValidCreditInstruction()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── CreditInstruction minimum-count (1..∞) ───────────────────────────────────

    [Fact]
    public void CreditInstruction_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditInstruction).To([]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CreditInstruction");
    }

    [Fact]
    public void CreditInstruction_MultipleElements_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditInstruction).To([ValidCreditInstruction(), IsoDataFactory.With(ValidCreditInstruction(), b2 => b2
                .Set(x2 => x2.CreditIdentification).To("CDT-002"))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Nested validation propagation ────────────────────────────────────────────

    [Fact]
    public void CreditInstruction_WithEmptyDirectDebitTransactionInformation_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditInstruction).To([IsoDataFactory.With(ValidCreditInstruction(), b2 => b2
                .Set(x2 => x2.DirectDebitTransactionInformation).To([]))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName.EndsWith("DirectDebitTransactionInformation"));
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
