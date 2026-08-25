// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

/// <summary>
/// Validates <see cref="FIToFIPaymentReversalV14"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pacs.007.001.14 (_fSVgYZe9EfCsfrvk22Hpaw), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). Fourth message built for the pacs
/// business area.
///
/// The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to
/// the next party in the payment chain. It is used to reverse a payment previously executed.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader127 — required (1..1)</description></item>
///   <item><term>OriginalGroupInformation</term><description>OriginalGroupHeader20 — optional (0..1)</description></item>
///   <item><term>TransactionInformation</term><description>PaymentTransaction182 collection — optional (0..&#8734;)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// Constraints (from spec) — 11 of 13 enforced here (2 are not independently enforceable, noted
/// below):
/// <list type="bullet">
///   <item>
///     <term>GroupReversalAndTransactionInformationNotPresentRule</term>
///     <description>If GroupHeader.GroupReversal is true, then TransactionInformation is not allowed.</description>
///   </item>
///   <item>
///     <term>GroupReversalAndTransactionInformationPresentRule</term>
///     <description>If GroupHeader.GroupReversal is false, then at least one TransactionInformation must be present.</description>
///   </item>
///   <item>
///     <term>GroupReversalAndReasonRule</term>
///     <description>
///       If GroupHeader.GroupReversal is true, then OriginalGroupInformation must be present and
///       its ReversalReasonInformation must contain at least one entry whose Reason is present.
///     </description>
///   </item>
///   <item>
///     <term>InstructedAgentRule</term>
///     <description>If GroupHeader.InstructedAgent is present, then every TransactionInformation[*].InstructedAgent must be absent.</description>
///   </item>
///   <item>
///     <term>InstructingAgentRule</term>
///     <description>If GroupHeader.InstructingAgent is present, then every TransactionInformation[*].InstructingAgent must be absent.</description>
///   </item>
///   <item>
///     <term>GroupHeaderInterbankSettlementDateRule</term>
///     <description>If GroupHeader.InterbankSettlementDate is present, then every TransactionInformation[*].InterbankSettlementDate must be absent.</description>
///   </item>
///   <item>
///     <term>TransactionInterbankSettlementDateRule</term>
///     <description>If GroupHeader.InterbankSettlementDate is absent, then every TransactionInformation[*].InterbankSettlementDate must be present.</description>
///   </item>
///   <item>
///     <term>GroupReversalAndNumberOfTransactionsRule</term>
///     <description>If GroupHeader.GroupReversal is false, then GroupHeader.NumberOfTransactions must equal the count of TransactionInformation.</description>
///   </item>
///   <item>
///     <term>TotalReversedInterbankSettlementAmountRule</term>
///     <description>If GroupHeader.TotalReversedInterbankSettlementAmount is present, then every TransactionInformation[*].ReversedInterbankSettlementAmount must share its currency.</description>
///   </item>
///   <item>
///     <term>TotalReversedInterbankSettlementAmountAndSumRule</term>
///     <description>GroupHeader.TotalReversedInterbankSettlementAmount, when present, must equal the sum of all TransactionInformation[*].ReversedInterbankSettlementAmount.</description>
///   </item>
///   <item>
///     <term>OriginalGroupInformationRule</term>
///     <description>If (message-level) OriginalGroupInformation is present, then every TransactionInformation[*].OriginalGroupInformation must be absent.</description>
///   </item>
///   <item>
///     <term>NoCoverSettlementMethodRule</term>
///     <description>
///       GroupHeader.SettlementInformation.SettlementMethod must be different from COVE (Cover)
///       when reversing direct debit transactions. Not independently enforceable by this
///       library — no structural signal on this message distinguishes "reversing a direct debit"
///       from "reversing a credit transfer"; that distinction lives in the original instruction
///       this reversal refers to, not in any field of this message itself.
///     </description>
///   </item>
///   <item>
///     <term>SupplementaryDataRule</term>
///     <description>
///       The SupplementaryData building block at message level must not be used to provide
///       additional information about a transaction — the SupplementaryData element at
///       transaction level should be used for that purpose instead. Not independently
///       enforceable by this library — no structural signal distinguishes message-level-scoped
///       content from transaction-scoped content inside a <see cref="SupplementaryData1"/>
///       instance at the C# model level.
///     </description>
///   </item>
/// </list>
///
/// Dependency injection: <c>GroupHeader</c>, <c>OriginalGroupInformation</c>,
/// <c>TransactionInformation</c>, and <c>SupplementaryData</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class FIToFIPaymentReversalV14Validator : AbstractValidator<FIToFIPaymentReversalV14>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public FIToFIPaymentReversalV14Validator(
        IValidator<GroupHeader127> groupHeaderValidator,
        IValidator<OriginalGroupHeader20> originalGroupInformationValidator,
        IValidator<PaymentTransaction182> transactionInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);

        When(
            x => x.OriginalGroupInformation is not null,
            () => RuleFor(x => x.OriginalGroupInformation).SetValidator(originalGroupInformationValidator!)
        );

        RuleForEach(x => x.TransactionInformation).SetValidator(transactionInformationValidator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);

        // ── GroupReversalAndTransactionInformationNotPresentRule ─────────────────────
        RuleFor(x => x)
            .Must(x => x.GroupHeader.GroupReversal?.BoolValue != true || x.TransactionInformation.Count == 0)
            .WithName("GroupReversalAndTransactionInformationNotPresentRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if GroupHeader.GroupReversal is true, "
                    + "TransactionInformation is not allowed (GroupReversalAndTransactionInformationNotPresentRule)."
            );

        // ── GroupReversalAndTransactionInformationPresentRule ────────────────────────
        RuleFor(x => x)
            .Must(x => x.GroupHeader.GroupReversal?.BoolValue != false || x.TransactionInformation.Count >= 1)
            .WithName("GroupReversalAndTransactionInformationPresentRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if GroupHeader.GroupReversal is false, at least one "
                    + "TransactionInformation must be present (GroupReversalAndTransactionInformationPresentRule)."
            );

        // ── GroupReversalAndReasonRule ────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.GroupReversal?.BoolValue != true
                || (x.OriginalGroupInformation?.ReversalReasonInformation.Any(r => r.Reason is not null) ?? false)
            )
            .WithName("GroupReversalAndReasonRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if GroupHeader.GroupReversal is true, "
                    + "OriginalGroupInformation.ReversalReasonInformation[*].Reason must be present (GroupReversalAndReasonRule)."
            );

        // ── InstructedAgentRule ───────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InstructedAgent is null
                || x.TransactionInformation.All(t => t.InstructedAgent is null)
            )
            .WithName("InstructedAgentRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if GroupHeader.InstructedAgent is present, every "
                    + "TransactionInformation[*].InstructedAgent must be absent (InstructedAgentRule)."
            );

        // ── InstructingAgentRule ──────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InstructingAgent is null
                || x.TransactionInformation.All(t => t.InstructingAgent is null)
            )
            .WithName("InstructingAgentRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if GroupHeader.InstructingAgent is present, every "
                    + "TransactionInformation[*].InstructingAgent must be absent (InstructingAgentRule)."
            );

        // ── GroupHeaderInterbankSettlementDateRule ───────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InterbankSettlementDate is null
                || x.TransactionInformation.All(t => t.InterbankSettlementDate is null)
            )
            .WithName("GroupHeaderInterbankSettlementDateRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if GroupHeader.InterbankSettlementDate is present, "
                    + "every TransactionInformation[*].InterbankSettlementDate must be absent "
                    + "(GroupHeaderInterbankSettlementDateRule)."
            );

        // ── TransactionInterbankSettlementDateRule ───────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InterbankSettlementDate is not null
                || x.TransactionInformation.All(t => t.InterbankSettlementDate is not null)
            )
            .WithName("TransactionInterbankSettlementDateRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if GroupHeader.InterbankSettlementDate is absent, "
                    + "every TransactionInformation[*].InterbankSettlementDate must be present "
                    + "(TransactionInterbankSettlementDateRule)."
            );

        // ── GroupReversalAndNumberOfTransactionsRule ─────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.GroupReversal?.BoolValue != false
                || (int.TryParse((string)x.GroupHeader.NumberOfTransactions, out var n)
                    && n == x.TransactionInformation.Count)
            )
            .WithName("GroupReversalAndNumberOfTransactionsRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if GroupHeader.GroupReversal is false, "
                    + "GroupHeader.NumberOfTransactions must equal the count of TransactionInformation "
                    + "(GroupReversalAndNumberOfTransactionsRule)."
            );

        // ── TotalReversedInterbankSettlementAmountRule ───────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.TotalReversedInterbankSettlementAmount is null
                || x.TransactionInformation.All(t =>
                    t.ReversedInterbankSettlementAmount.Currency
                    == x.GroupHeader.TotalReversedInterbankSettlementAmount.Currency
                )
            )
            .WithName("TotalReversedInterbankSettlementAmountRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if GroupHeader.TotalReversedInterbankSettlementAmount "
                    + "is present, every TransactionInformation[*].ReversedInterbankSettlementAmount "
                    + "must share its currency (TotalReversedInterbankSettlementAmountRule)."
            );

        // ── TotalReversedInterbankSettlementAmountAndSumRule ─────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.TotalReversedInterbankSettlementAmount is null
                || x.GroupHeader.TotalReversedInterbankSettlementAmount.Amount
                    == x.TransactionInformation.Sum(t => t.ReversedInterbankSettlementAmount.Amount)
            )
            .WithName("TotalReversedInterbankSettlementAmountAndSumRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: GroupHeader.TotalReversedInterbankSettlementAmount, "
                    + "when present, must equal the sum of all "
                    + "TransactionInformation[*].ReversedInterbankSettlementAmount "
                    + "(TotalReversedInterbankSettlementAmountAndSumRule)."
            );

        // ── OriginalGroupInformationRule ──────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformation is null
                || x.TransactionInformation.All(t => t.OriginalGroupInformation is null)
            )
            .WithName("OriginalGroupInformationRule")
            .WithMessage(
                "FIToFIPaymentReversalV14: if (message-level) OriginalGroupInformation is present, "
                    + "every TransactionInformation[*].OriginalGroupInformation must be absent "
                    + "(OriginalGroupInformationRule)."
            );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public FIToFIPaymentReversalV14Validator()
        : this(
            new GroupHeader127Validator(),
            new OriginalGroupHeader20Validator(),
            new PaymentTransaction182Validator(),
            new SupplementaryData1Validator()
        ) { }
}
