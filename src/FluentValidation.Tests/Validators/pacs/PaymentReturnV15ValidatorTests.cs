// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class PaymentReturnV15ValidatorTests
{
    private readonly PaymentReturnV15Validator _sut = new();

    private static IGroupHeader123 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader123>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.SettlementInformation).To(IsoDataFactory.Make<ISettlementInstruction15>(b2 => b2
                .Set(x2 => x2.SettlementMethod).To(SettlementMethod1Code.ClearingSystem))));

    private static IPaymentTransaction168 ValidTransaction() =>
        IsoDataFactory.Make<IPaymentTransaction168>(b => b
            .Set(x => x.InterbankSettlementDate).To(new DateOnly(2026, 1, 1))
            .Set(x => x.ReturnedInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }));

    private static IPaymentReturnV15 ValidMessage() =>
        IsoDataFactory.Make<IPaymentReturnV15>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.TransactionInformation).To([ValidTransaction()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── GroupReturnAndTransactionInformationNotPresentRule / PresentRule ─────────

    [Fact]
    public void GroupReturnTrue_TransactionInformationPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
            .Set(x2 => x2.GroupReturn).To(true))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReturnAndTransactionInformationNotPresentRule");
    }

    [Fact]
    public void GroupReturnFalse_TransactionInformationAbsent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
            .Set(x2 => x2.GroupReturn).To(false)))
            .Set(x => x.TransactionInformation).To([]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReturnAndTransactionInformationPresentRule");
    }

    // ── GroupReturnAndReturnReasonRule ────────────────────────────────────────────

    [Fact]
    public void GroupReturnTrue_NoReturnReason_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.GroupReturn).To(true)))
            .Set(x => x.TransactionInformation).To([]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReturnAndReturnReasonRule");
    }

    [Fact]
    public void GroupReturnTrue_ReturnReasonPresent_NoValidationError_ForReturnReasonRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.GroupReturn).To(true)))
            .Set(x => x.TransactionInformation).To([])
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupHeader19>(b2 => b2
                .Set(x2 => x2.OriginalMessageIdentification).To("ORGMSG-001")
                .Set(x2 => x2.OriginalMessageNameIdentification).To("pacs.008.001.14")
                .Set(x2 => x2.ReturnReasonInformation).To([
                    IsoDataFactory.Make<IPaymentReturnReason7>(b3 => b3
                        .Set(x3 => x3.Reason).To(IsoDataFactory.Make<Choices.ReturnReason5Choice.IProprietary>(b4 => b4
                            .Set(x4 => x4.Value).To("NARR")))),
                ]))));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupReturnAndReturnReasonRule");
    }

    // ── InstructedAgentRule / InstructingAgentRule ────────────────────────────────

    [Fact]
    public void GroupHeaderInstructedAgentPresent_TransactionInstructedAgentPresent_HasValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
                .Set(x2 => x2.BICFI).To("BOFAUS3NXXX"))));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InstructedAgent).To(agent)))
            .Set(x => x.TransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.InstructedAgent).To(agent))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructedAgentRule");
    }

    [Fact]
    public void GroupHeaderInstructingAgentPresent_TransactionInstructingAgentPresent_HasValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
                .Set(x2 => x2.BICFI).To("BOFAUS3NXXX"))));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InstructingAgent).To(agent)))
            .Set(x => x.TransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.InstructingAgent).To(agent))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructingAgentRule");
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
            .Set(x => x.TransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
            .Set(x2 => x2.InterbankSettlementDate).To(null))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TransactionInterbankSettlementDateRule");
    }

    // ── GroupReturnAndNumberOfTransactionsRule ───────────────────────────────────

    [Fact]
    public void GroupReturnFalse_NumberOfTransactionsMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.GroupReturn).To(false)
                .Set(x2 => x2.NumberOfTransactions).To("2"))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReturnAndNumberOfTransactionsRule");
    }

    [Fact]
    public void GroupReturnFalse_NumberOfTransactionsMatches_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.GroupReturn).To(false)
                .Set(x2 => x2.NumberOfTransactions).To("1"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── TotalReturnedInterbankSettlementAmountRule / AndSumRule ──────────────────

    [Fact]
    public void TotalReturnedInterbankSettlementAmountCurrencyMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.TotalReturnedInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m }))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReturnedInterbankSettlementAmountRule");
    }

    [Fact]
    public void TotalReturnedInterbankSettlementAmountSumMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.TotalReturnedInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 999m }))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReturnedInterbankSettlementAmountAndSumRule");
    }

    [Fact]
    public void TotalReturnedInterbankSettlementAmountMatchesSumAndCurrency_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.TotalReturnedInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationRule ──────────────────────────────────────────────

    [Fact]
    public void MessageLevelOriginalGroupInformationPresent_TransactionOriginalGroupInformationPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupHeader19>(b2 => b2
                .Set(x2 => x2.OriginalMessageIdentification).To("ORGMSG-001")
                .Set(x2 => x2.OriginalMessageNameIdentification).To("pacs.008.001.14")))
            .Set(x => x.TransactionInformation).To([
                IsoDataFactory.With(ValidTransaction(), b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupInformation33>(b3 => b3
                        .Set(x3 => x3.OriginalMessageIdentification).To("ORGMSG-002")
                        .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.14")))),
            ]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationRule");
    }

    // ── PaymentTypeInformationRule ────────────────────────────────────────────────

    [Fact]
    public void GroupHeaderPaymentTypeInformationPresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation28>())))
            .Set(x => x.TransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation28>()))]));
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
