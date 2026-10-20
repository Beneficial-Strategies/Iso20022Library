// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FIToFICustomerCreditTransferV14ValidatorTests
{
    private readonly FIToFICustomerCreditTransferV14Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static IGroupHeader131 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader131>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.SettlementInformation).To(IsoDataFactory.Make<ISettlementInstruction15>(b2 => b2
                .Set(x2 => x2.SettlementMethod).To(SettlementMethod1Code.ClearingSystem))));

    private static ICreditTransferTransaction73 ValidTransaction() =>
        IsoDataFactory.Make<ICreditTransferTransaction73>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.InterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m })
            .Set(x => x.InterbankSettlementDate).To(new DateOnly(2026, 1, 1))
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.Shared)
            .Set(x => x.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.DebtorAgent).To(ValidAgent("DEUTDEFFXXX"))
            .Set(x => x.CreditorAgent).To(ValidAgent("CHASUS33XXX"))
            .Set(x => x.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>()));

    private static IFIToFICustomerCreditTransferV14 ValidMessage() =>
        IsoDataFactory.Make<IFIToFICustomerCreditTransferV14>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.CreditTransferTransactionInformation).To([ValidTransaction()]));

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
            .Set(x => x.CreditTransferTransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
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
            .Set(x => x.CreditTransferTransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
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
            .Set(x => x.CreditTransferTransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
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
                .Set(x2 => x2.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation28>())))
            .Set(x => x.CreditTransferTransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation28>()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "PaymentTypeInformationRule");
    }

    // ── NumberOfTransactionsAndCreditTransfersRule ───────────────────────────────

    [Fact]
    public void NumberOfTransactionsMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
            .Set(x2 => x2.NumberOfTransactions).To("2"))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "NumberOfTransactionsAndCreditTransfersRule");
    }

    [Fact]
    public void NumberOfTransactionsMatches_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditTransferTransactionInformation).To([ValidTransaction(), ValidTransaction()])
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.NumberOfTransactions).To("2"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── GroupHeaderExpiryDateTimeRule ─────────────────────────────────────────────

    [Fact]
    public void GroupHeaderExpiryDateTimePresent_TransactionAdditionalDateTimeExpiryAlsoPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.ExpiryDateTime).To(new DateTime(2026, 2, 1))))
            .Set(x => x.CreditTransferTransactionInformation).To([
                IsoDataFactory.With(ValidTransaction(), b2 => b2
                    .Set(x2 => x2.AdditionalDateTime).To(IsoDataFactory.Make<IAdditionalDateTime1>(b3 => b3
                        .Set(x3 => x3.ExpiryDateTime).To(new DateTime(2026, 2, 1))))),
            ]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupHeaderExpiryDateTimeRule");
    }

    [Fact]
    public void GroupHeaderExpiryDateTimePresent_TransactionAdditionalDateTimeExpiryAbsent_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.ExpiryDateTime).To(new DateTime(2026, 2, 1)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
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
