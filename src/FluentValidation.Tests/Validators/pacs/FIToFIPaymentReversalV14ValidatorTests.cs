// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FIToFIPaymentReversalV14ValidatorTests
{
    private readonly FIToFIPaymentReversalV14Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static IGroupHeader127 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader127>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.SettlementInformation).To(IsoDataFactory.Make<ISettlementInstruction15>(b2 => b2
                .Set(x2 => x2.SettlementMethod).To(SettlementMethod1Code.ClearingSystem))));

    private static IPaymentTransaction182 ValidTransaction() =>
        IsoDataFactory.Make<IPaymentTransaction182>(b => b
            .Set(x => x.ReversedInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m })
            .Set(x => x.InterbankSettlementDate).To(new DateOnly(2026, 1, 1)));

    private static IFIToFIPaymentReversalV14 ValidMessage() =>
        IsoDataFactory.Make<IFIToFIPaymentReversalV14>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.TransactionInformation).To([ValidTransaction()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── GroupReversalAndTransactionInformationNotPresentRule ─────────────────────

    [Fact]
    public void GroupReversalTrue_TransactionInformationPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
            .Set(x2 => x2.GroupReversal).To(true))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndTransactionInformationNotPresentRule");
    }

    [Fact]
    public void GroupReversalTrue_TransactionInformationAbsent_NoValidationError_ForThatRule()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentReversalV14>(b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.GroupReversal).To(true)))
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupHeader20>(b2 => b2
                .Set(x2 => x2.OriginalMessageIdentification).To("OMSG-001")
                .Set(x2 => x2.OriginalMessageNameIdentification).To("pacs.007.001.14")
                .Set(x2 => x2.ReversalReasonInformation).To([IsoDataFactory.Make<IPaymentReversalReason10>(b3 => b3
                    .Set(x3 => x3.Reason).To(ValidReason()))]))));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupReversalAndTransactionInformationNotPresentRule");
    }

    private static BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice.ICode ValidReason() =>
        IsoDataFactory.Make<Choices.ReversalReason4Choice.ICode>(b => b
            .Set(x => x.Value).To(ExternalReversalReason1Code.InvalidCreditorAccountNumber));

    // ── GroupReversalAndTransactionInformationPresentRule ────────────────────────

    [Fact]
    public void GroupReversalFalse_TransactionInformationEmpty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.GroupReversal).To(false)))
            .Set(x => x.TransactionInformation).To([]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndTransactionInformationPresentRule");
    }

    [Fact]
    public void GroupReversalFalse_TransactionInformationPresent_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
            .Set(x2 => x2.GroupReversal).To(false))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── GroupReversalAndReasonRule ────────────────────────────────────────────────

    [Fact]
    public void GroupReversalTrue_NoReason_HasValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentReversalV14>(b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
            .Set(x2 => x2.GroupReversal).To(true))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndReasonRule");
    }

    [Fact]
    public void GroupReversalTrue_WithReason_NoValidationError_ForThatRule()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentReversalV14>(b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.GroupReversal).To(true)))
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupHeader20>(b2 => b2
                .Set(x2 => x2.OriginalMessageIdentification).To("OMSG-001")
                .Set(x2 => x2.OriginalMessageNameIdentification).To("pacs.007.001.14")
                .Set(x2 => x2.ReversalReasonInformation).To([IsoDataFactory.Make<IPaymentReversalReason10>(b3 => b3
                    .Set(x3 => x3.Reason).To(ValidReason()))]))));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupReversalAndReasonRule");
    }

    // ── InstructedAgentRule / InstructingAgentRule ────────────────────────────────

    [Fact]
    public void GroupHeaderInstructedAgentPresent_TransactionInstructedAgentPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InstructedAgent).To(ValidAgent("DEUTDEFFXXX"))))
            .Set(x => x.TransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.InstructedAgent).To(ValidAgent("CHASUS33XXX")))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructedAgentRule");
    }

    [Fact]
    public void GroupHeaderInstructingAgentPresent_TransactionInstructingAgentPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InstructingAgent).To(ValidAgent("DEUTDEFFXXX"))))
            .Set(x => x.TransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.InstructingAgent).To(ValidAgent("CHASUS33XXX")))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructingAgentRule");
    }

    // ── GroupHeaderInterbankSettlementDateRule / TransactionInterbankSettlementDateRule ──

    [Fact]
    public void GroupHeaderInterbankSettlementDatePresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InterbankSettlementDate).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.TransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.InterbankSettlementDate).To(new DateOnly(2026, 1, 1)))]));
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

    [Fact]
    public void GroupHeaderInterbankSettlementDatePresent_TransactionAbsent_NoValidationErrorForDateRules()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InterbankSettlementDate).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.TransactionInformation).To([IsoDataFactory.With(ValidTransaction(), b2 => b2
                .Set(x2 => x2.InterbankSettlementDate).To(null))]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupHeaderInterbankSettlementDateRule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TransactionInterbankSettlementDateRule");
    }

    // ── GroupReversalAndNumberOfTransactionsRule ─────────────────────────────────

    [Fact]
    public void GroupReversalFalse_NumberOfTransactionsMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.GroupReversal).To(false)
                .Set(x2 => x2.NumberOfTransactions).To("2"))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndNumberOfTransactionsRule");
    }

    [Fact]
    public void GroupReversalFalse_NumberOfTransactionsMatches_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.GroupReversal).To(false)
                .Set(x2 => x2.NumberOfTransactions).To("1"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── TotalReversedInterbankSettlementAmountRule / AndSumRule ──────────────────

    [Fact]
    public void TotalReversedAmountCurrencyMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.TotalReversedInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m }))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReversedInterbankSettlementAmountRule");
    }

    [Fact]
    public void TotalReversedAmountSumMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.TotalReversedInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 999m }))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReversedInterbankSettlementAmountAndSumRule");
    }

    [Fact]
    public void TotalReversedAmountMatchesSumAndCurrency_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.TotalReversedInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationRule ──────────────────────────────────────────────

    [Fact]
    public void MessageLevelOriginalGroupInformationPresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupHeader20>(b2 => b2
                .Set(x2 => x2.OriginalMessageIdentification).To("OMSG-001")
                .Set(x2 => x2.OriginalMessageNameIdentification).To("pacs.007.001.14")))
            .Set(x => x.TransactionInformation).To([
                IsoDataFactory.With(ValidTransaction(), b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupInformation33>(b3 => b3
                        .Set(x3 => x3.OriginalMessageIdentification).To("OMSG-001")
                        .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.007.001.14")))),
            ]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationRule");
    }

    [Fact]
    public void MessageLevelOriginalGroupInformationPresent_TransactionAbsent_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupHeader20>(b2 => b2
                .Set(x2 => x2.OriginalMessageIdentification).To("OMSG-001")
                .Set(x2 => x2.OriginalMessageNameIdentification).To("pacs.007.001.14"))));
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
