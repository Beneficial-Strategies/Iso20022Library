// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FIToFIPaymentReversalV14ValidatorTests
{
    private readonly FIToFIPaymentReversalV14Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static GroupHeader127 ValidGroupHeader() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = "1",
            SettlementInformation = new SettlementInstruction15 { SettlementMethod = SettlementMethod1Code.ClearingSystem },
        };

    private static PaymentTransaction182 ValidTransaction() =>
        new()
        {
            ReversedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            // GroupHeader carries no InterbankSettlementDate in these fixtures, so — per
            // TransactionInterbankSettlementDateRule — each transaction must carry its own.
            InterbankSettlementDate = new DateOnly(2026, 1, 1),
        };

    private static FIToFIPaymentReversalV14 ValidMessage() =>
        new() { GroupHeader = ValidGroupHeader(), TransactionInformation = [ValidTransaction()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── GroupReversalAndTransactionInformationNotPresentRule ─────────────────────

    [Fact]
    public void GroupReversalTrue_TransactionInformationPresent_HasValidationError()
    {
        var msg = ValidMessage() with { GroupHeader = ValidGroupHeader() with { GroupReversal = true } };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndTransactionInformationNotPresentRule");
    }

    [Fact]
    public void GroupReversalTrue_TransactionInformationAbsent_NoValidationError_ForThatRule()
    {
        var msg = new FIToFIPaymentReversalV14
        {
            GroupHeader = ValidGroupHeader() with { GroupReversal = true },
            OriginalGroupInformation = new OriginalGroupHeader20
            {
                OriginalMessageIdentification = "OMSG-001",
                OriginalMessageNameIdentification = "pacs.007.001.14",
                ReversalReasonInformation = [new PaymentReversalReason10 { Reason = ValidReason() }],
            },
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupReversalAndTransactionInformationNotPresentRule");
    }

    private static BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice.Code ValidReason() =>
        new() { Value = ExternalReversalReason1Code.InvalidCreditorAccountNumber };

    // ── GroupReversalAndTransactionInformationPresentRule ────────────────────────

    [Fact]
    public void GroupReversalFalse_TransactionInformationEmpty_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { GroupReversal = false },
            TransactionInformation = [],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndTransactionInformationPresentRule");
    }

    [Fact]
    public void GroupReversalFalse_TransactionInformationPresent_NoValidationError()
    {
        var msg = ValidMessage() with { GroupHeader = ValidGroupHeader() with { GroupReversal = false } };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── GroupReversalAndReasonRule ────────────────────────────────────────────────

    [Fact]
    public void GroupReversalTrue_NoReason_HasValidationError()
    {
        var msg = new FIToFIPaymentReversalV14 { GroupHeader = ValidGroupHeader() with { GroupReversal = true } };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndReasonRule");
    }

    [Fact]
    public void GroupReversalTrue_WithReason_NoValidationError_ForThatRule()
    {
        var msg = new FIToFIPaymentReversalV14
        {
            GroupHeader = ValidGroupHeader() with { GroupReversal = true },
            OriginalGroupInformation = new OriginalGroupHeader20
            {
                OriginalMessageIdentification = "OMSG-001",
                OriginalMessageNameIdentification = "pacs.007.001.14",
                ReversalReasonInformation = [new PaymentReversalReason10 { Reason = ValidReason() }],
            },
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupReversalAndReasonRule");
    }

    // ── InstructedAgentRule / InstructingAgentRule ────────────────────────────────

    [Fact]
    public void GroupHeaderInstructedAgentPresent_TransactionInstructedAgentPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InstructedAgent = ValidAgent("DEUTDEFFXXX") },
            TransactionInformation = [ValidTransaction() with { InstructedAgent = ValidAgent("CHASUS33XXX") }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructedAgentRule");
    }

    [Fact]
    public void GroupHeaderInstructingAgentPresent_TransactionInstructingAgentPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InstructingAgent = ValidAgent("DEUTDEFFXXX") },
            TransactionInformation = [ValidTransaction() with { InstructingAgent = ValidAgent("CHASUS33XXX") }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructingAgentRule");
    }

    // ── GroupHeaderInterbankSettlementDateRule / TransactionInterbankSettlementDateRule ──

    [Fact]
    public void GroupHeaderInterbankSettlementDatePresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InterbankSettlementDate = new DateOnly(2026, 1, 1) },
            TransactionInformation = [ValidTransaction() with { InterbankSettlementDate = new DateOnly(2026, 1, 1) }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupHeaderInterbankSettlementDateRule");
    }

    [Fact]
    public void GroupHeaderInterbankSettlementDateAbsent_TransactionAlsoAbsent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            TransactionInformation = [ValidTransaction() with { InterbankSettlementDate = null }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TransactionInterbankSettlementDateRule");
    }

    [Fact]
    public void GroupHeaderInterbankSettlementDatePresent_TransactionAbsent_NoValidationErrorForDateRules()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InterbankSettlementDate = new DateOnly(2026, 1, 1) },
            TransactionInformation = [ValidTransaction() with { InterbankSettlementDate = null }],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupHeaderInterbankSettlementDateRule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TransactionInterbankSettlementDateRule");
    }

    // ── GroupReversalAndNumberOfTransactionsRule ─────────────────────────────────

    [Fact]
    public void GroupReversalFalse_NumberOfTransactionsMismatch_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { GroupReversal = false, NumberOfTransactions = "2" },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndNumberOfTransactionsRule");
    }

    [Fact]
    public void GroupReversalFalse_NumberOfTransactionsMatches_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { GroupReversal = false, NumberOfTransactions = "1" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── TotalReversedInterbankSettlementAmountRule / AndSumRule ──────────────────

    [Fact]
    public void TotalReversedAmountCurrencyMismatch_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with
            {
                TotalReversedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReversedInterbankSettlementAmountRule");
    }

    [Fact]
    public void TotalReversedAmountSumMismatch_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with
            {
                TotalReversedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 999m },
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReversedInterbankSettlementAmountAndSumRule");
    }

    [Fact]
    public void TotalReversedAmountMatchesSumAndCurrency_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with
            {
                TotalReversedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationRule ──────────────────────────────────────────────

    [Fact]
    public void MessageLevelOriginalGroupInformationPresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformation = new OriginalGroupHeader20
            {
                OriginalMessageIdentification = "OMSG-001",
                OriginalMessageNameIdentification = "pacs.007.001.14",
            },
            TransactionInformation =
            [
                ValidTransaction() with
                {
                    OriginalGroupInformation = new OriginalGroupInformation33
                    {
                        OriginalMessageIdentification = "OMSG-001",
                        OriginalMessageNameIdentification = "pacs.007.001.14",
                    },
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationRule");
    }

    [Fact]
    public void MessageLevelOriginalGroupInformationPresent_TransactionAbsent_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformation = new OriginalGroupHeader20
            {
                OriginalMessageIdentification = "OMSG-001",
                OriginalMessageNameIdentification = "pacs.007.001.14",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
