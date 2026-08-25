// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class PaymentReturnV15ValidatorTests
{
    private readonly PaymentReturnV15Validator _sut = new();

    private static GroupHeader123 ValidGroupHeader() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = "1",
            SettlementInformation = new SettlementInstruction15 { SettlementMethod = SettlementMethod1Code.ClearingSystem },
        };

    private static PaymentTransaction168 ValidTransaction() =>
        new()
        {
            // GroupHeader carries no InterbankSettlementDate in these fixtures, so — per
            // TransactionInterbankSettlementDateRule — each transaction must carry its own.
            InterbankSettlementDate = new DateOnly(2026, 1, 1),
            ReturnedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };

    private static PaymentReturnV15 ValidMessage() =>
        new() { GroupHeader = ValidGroupHeader(), TransactionInformation = [ValidTransaction()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── GroupReturnAndTransactionInformationNotPresentRule / PresentRule ─────────

    [Fact]
    public void GroupReturnTrue_TransactionInformationPresent_HasValidationError()
    {
        var msg = ValidMessage() with { GroupHeader = ValidGroupHeader() with { GroupReturn = true } };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReturnAndTransactionInformationNotPresentRule");
    }

    [Fact]
    public void GroupReturnFalse_TransactionInformationAbsent_HasValidationError()
    {
        var msg = ValidMessage() with { GroupHeader = ValidGroupHeader() with { GroupReturn = false }, TransactionInformation = [] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReturnAndTransactionInformationPresentRule");
    }

    // ── GroupReturnAndReturnReasonRule ────────────────────────────────────────────

    [Fact]
    public void GroupReturnTrue_NoReturnReason_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { GroupReturn = true },
            TransactionInformation = [],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReturnAndReturnReasonRule");
    }

    [Fact]
    public void GroupReturnTrue_ReturnReasonPresent_NoValidationError_ForReturnReasonRule()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { GroupReturn = true },
            TransactionInformation = [],
            OriginalGroupInformation = new OriginalGroupHeader19
            {
                OriginalMessageIdentification = "ORGMSG-001",
                OriginalMessageNameIdentification = "pacs.008.001.14",
                ReturnReasonInformation =
                [
                    new PaymentReturnReason7
                    {
                        Reason = new BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice.Proprietary { Value = "NARR" },
                    },
                ],
            },
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupReturnAndReturnReasonRule");
    }

    // ── InstructedAgentRule / InstructingAgentRule ────────────────────────────────

    [Fact]
    public void GroupHeaderInstructedAgentPresent_TransactionInstructedAgentPresent_HasValidationError()
    {
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "BOFAUS3NXXX" },
        };
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InstructedAgent = agent },
            TransactionInformation = [ValidTransaction() with { InstructedAgent = agent }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructedAgentRule");
    }

    [Fact]
    public void GroupHeaderInstructingAgentPresent_TransactionInstructingAgentPresent_HasValidationError()
    {
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "BOFAUS3NXXX" },
        };
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InstructingAgent = agent },
            TransactionInformation = [ValidTransaction() with { InstructingAgent = agent }],
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
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupHeaderInterbankSettlementDateRule");
    }

    [Fact]
    public void GroupHeaderInterbankSettlementDateAbsent_TransactionAlsoAbsent_HasValidationError()
    {
        var msg = ValidMessage() with { TransactionInformation = [ValidTransaction() with { InterbankSettlementDate = null }] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TransactionInterbankSettlementDateRule");
    }

    // ── GroupReturnAndNumberOfTransactionsRule ───────────────────────────────────

    [Fact]
    public void GroupReturnFalse_NumberOfTransactionsMismatch_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { GroupReturn = false, NumberOfTransactions = "2" },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReturnAndNumberOfTransactionsRule");
    }

    [Fact]
    public void GroupReturnFalse_NumberOfTransactionsMatches_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { GroupReturn = false, NumberOfTransactions = "1" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── TotalReturnedInterbankSettlementAmountRule / AndSumRule ──────────────────

    [Fact]
    public void TotalReturnedInterbankSettlementAmountCurrencyMismatch_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with
            {
                TotalReturnedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReturnedInterbankSettlementAmountRule");
    }

    [Fact]
    public void TotalReturnedInterbankSettlementAmountSumMismatch_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with
            {
                TotalReturnedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 999m },
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReturnedInterbankSettlementAmountAndSumRule");
    }

    [Fact]
    public void TotalReturnedInterbankSettlementAmountMatchesSumAndCurrency_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with
            {
                TotalReturnedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationRule ──────────────────────────────────────────────

    [Fact]
    public void MessageLevelOriginalGroupInformationPresent_TransactionOriginalGroupInformationPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformation = new OriginalGroupHeader19
            {
                OriginalMessageIdentification = "ORGMSG-001",
                OriginalMessageNameIdentification = "pacs.008.001.14",
            },
            TransactionInformation =
            [
                ValidTransaction() with
                {
                    OriginalGroupInformation = new OriginalGroupInformation33
                    {
                        OriginalMessageIdentification = "ORGMSG-002",
                        OriginalMessageNameIdentification = "pacs.008.001.14",
                    },
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationRule");
    }

    // ── PaymentTypeInformationRule ────────────────────────────────────────────────

    [Fact]
    public void GroupHeaderPaymentTypeInformationPresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { PaymentTypeInformation = new PaymentTypeInformation28() },
            TransactionInformation = [ValidTransaction() with { PaymentTypeInformation = new PaymentTypeInformation28() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "PaymentTypeInformationRule");
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
