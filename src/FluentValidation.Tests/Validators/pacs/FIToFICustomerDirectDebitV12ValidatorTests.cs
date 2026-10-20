// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FIToFICustomerDirectDebitV12ValidatorTests
{
    private readonly FIToFICustomerDirectDebitV12Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static ICashAccount40 ValidAccount(string id = "ACC-001") =>
        IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b2 => b2
            .Set(x2 => x2.Identification).To(id))));

    private static IGroupHeader125 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader125>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.SettlementInformation).To(IsoDataFactory.Make<ISettlementInstruction14>(b2 => b2
                .Set(x2 => x2.SettlementMethod).To(SettlementMethod2Code.ClearingSystem))));

    private static IDirectDebitTransactionInformation35 ValidTransaction() =>
        IsoDataFactory.Make<IDirectDebitTransactionInformation35>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.InterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m })
            .Set(x => x.InterbankSettlementDate).To(new DateOnly(2026, 1, 1))
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.Shared)
            .Set(x => x.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.CreditorAgent).To(ValidAgent("CHASUS33XXX"))
            .Set(x => x.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.DebtorAccount).To(ValidAccount())
            .Set(x => x.DebtorAgent).To(ValidAgent("DEUTDEFFXXX")));

    private static IFIToFICustomerDirectDebitV12 ValidMessage() =>
        IsoDataFactory.Make<IFIToFICustomerDirectDebitV12>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.DirectDebitTransactionInformation).To([ValidTransaction()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── InstructedAgentRule / InstructingAgentRule ────────────────────────────────

    [Fact]
    public void GroupHeaderInstructedAgentPresent_TransactionInstructedAgentPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InstructedAgent).To(ValidAgent("BOFAUS3NXXX"))))
            .Set(x => x.DirectDebitTransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.InstructedAgent).To(ValidAgent("BOFAUS3NXXX")))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructedAgentRule");
    }

    [Fact]
    public void GroupHeaderInstructingAgentPresent_TransactionInstructingAgentPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InstructingAgent).To(ValidAgent("BOFAUS3NXXX"))))
            .Set(x => x.DirectDebitTransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.InstructingAgent).To(ValidAgent("BOFAUS3NXXX")))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructingAgentRule");
    }

    // ── TotalInterbankSettlementAmountRule / AndSumRule ──────────────────────────

    [Fact]
    public void TotalInterbankSettlementAmountCurrencyMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.TotalInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m }))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmountRule");
    }

    [Fact]
    public void TotalInterbankSettlementAmountSumMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.TotalInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 999m }))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmountAndSumRule");
    }

    [Fact]
    public void TotalInterbankSettlementAmountMatchesSumAndCurrency_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.TotalInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── GroupHeaderInterbankSettlementDateRule / TransactionInterbankSettlementDateRule ──

    [Fact]
    public void GroupHeaderInterbankSettlementDatePresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InterbankSettlementDate).To(new DateOnly(2026, 1, 1)))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupHeaderInterbankSettlementDateRule");
    }

    [Fact]
    public void GroupHeaderInterbankSettlementDateAbsent_TransactionAlsoAbsent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DirectDebitTransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.InterbankSettlementDate).To(null))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TransactionInterbankSettlementDateRule");
    }

    // ── PaymentTypeInformationRule ────────────────────────────────────────────────

    [Fact]
    public void GroupHeaderPaymentTypeInformationPresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation27>())))
            .Set(x => x.DirectDebitTransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation27>()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "PaymentTypeInformationRule");
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
