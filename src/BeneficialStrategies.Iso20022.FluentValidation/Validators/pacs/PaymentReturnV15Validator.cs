// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

/// <summary>
/// Validates <see cref="PaymentReturnV15"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pacs.004.001.15 (e139f53a-df51-43c2-a761-b5231fafa5eb), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-26). Ninth and final message built for
/// the pacs business area — completes pacs 9/9, matching pain's completion pattern.
///
/// The PaymentReturn message is sent by an agent to the previous agent in the payment chain to
/// undo a payment previously settled.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader123 — required (1..1)</description></item>
///   <item><term>OriginalGroupInformation</term><description>OriginalGroupHeader19 — optional (0..1)</description></item>
///   <item><term>TransactionInformation</term><description>PaymentTransaction168 collection — optional (0..&#8734;)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// Constraints (from spec) — 12 of 14 enforced here (2 are not independently enforceable, noted
/// below). Same shape as <c>FIToFIPaymentReversalV14Validator</c>'s constraint set (its closest
/// sibling — GroupReturn plays the same role GroupReversal plays there), plus one extra:
/// <list type="bullet">
///   <item>
///     <term>GroupReturnAndTransactionInformationNotPresentRule</term>
///     <description>If GroupHeader.GroupReturn is true, then TransactionInformation is not allowed.</description>
///   </item>
///   <item>
///     <term>GroupReturnAndTransactionInformationPresentRule</term>
///     <description>If GroupHeader.GroupReturn is false, then at least one TransactionInformation must be present.</description>
///   </item>
///   <item>
///     <term>GroupReturnAndReturnReasonRule</term>
///     <description>
///       If GroupHeader.GroupReturn is true, then OriginalGroupInformation must be present and
///       its ReturnReasonInformation must contain at least one entry whose Reason is present.
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
///     <term>GroupReturnAndNumberOfTransactionsRule</term>
///     <description>If GroupHeader.GroupReturn is false, then GroupHeader.NumberOfTransactions must equal the count of TransactionInformation.</description>
///   </item>
///   <item>
///     <term>TotalReturnedInterbankSettlementAmountRule</term>
///     <description>If GroupHeader.TotalReturnedInterbankSettlementAmount is present, then every TransactionInformation[*].ReturnedInterbankSettlementAmount must share its currency.</description>
///   </item>
///   <item>
///     <term>TotalReturnedInterbankSettlementAmountAndSumRule</term>
///     <description>GroupHeader.TotalReturnedInterbankSettlementAmount, when present, must equal the sum of all TransactionInformation[*].ReturnedInterbankSettlementAmount.</description>
///   </item>
///   <item>
///     <term>OriginalGroupInformationRule</term>
///     <description>If (message-level) OriginalGroupInformation is present, then every TransactionInformation[*].OriginalGroupInformation must be absent.</description>
///   </item>
///   <item>
///     <term>PaymentTypeInformationRule</term>
///     <description>If GroupHeader.PaymentTypeInformation is present, then every TransactionInformation[*].PaymentTypeInformation must be absent.</description>
///   </item>
///   <item>
///     <term>NoCoverSettlementMethodRule</term>
///     <description>
///       GroupHeader.SettlementInformation.SettlementMethod must be different from COVE (Cover)
///       when returning direct debit transactions. Not independently enforceable by this
///       library — no structural signal on this message distinguishes "returning a direct debit"
///       from "returning a credit transfer"; that distinction lives in the original instruction
///       this return refers to, not in any field of this message itself.
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
public class PaymentReturnV15Validator : AbstractValidator<PaymentReturnV15>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentReturnV15Validator(
        IValidator<GroupHeader123> groupHeaderValidator,
        IValidator<OriginalGroupHeader19> originalGroupInformationValidator,
        IValidator<PaymentTransaction168> transactionInformationValidator,
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

        // ── GroupReturnAndTransactionInformationNotPresentRule ───────────────────────
        RuleFor(x => x)
            .Must(x => x.GroupHeader.GroupReturn?.BoolValue != true || x.TransactionInformation.Count == 0)
            .WithName("GroupReturnAndTransactionInformationNotPresentRule")
            .WithMessage(
                "PaymentReturnV15: if GroupHeader.GroupReturn is true, "
                    + "TransactionInformation is not allowed (GroupReturnAndTransactionInformationNotPresentRule)."
            );

        // ── GroupReturnAndTransactionInformationPresentRule ──────────────────────────
        RuleFor(x => x)
            .Must(x => x.GroupHeader.GroupReturn?.BoolValue != false || x.TransactionInformation.Count >= 1)
            .WithName("GroupReturnAndTransactionInformationPresentRule")
            .WithMessage(
                "PaymentReturnV15: if GroupHeader.GroupReturn is false, at least one "
                    + "TransactionInformation must be present (GroupReturnAndTransactionInformationPresentRule)."
            );

        // ── GroupReturnAndReturnReasonRule ────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.GroupReturn?.BoolValue != true
                || (x.OriginalGroupInformation?.ReturnReasonInformation.Any(r => r.Reason is not null) ?? false)
            )
            .WithName("GroupReturnAndReturnReasonRule")
            .WithMessage(
                "PaymentReturnV15: if GroupHeader.GroupReturn is true, "
                    + "OriginalGroupInformation.ReturnReasonInformation[*].Reason must be present (GroupReturnAndReturnReasonRule)."
            );

        // ── InstructedAgentRule ───────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InstructedAgent is null
                || x.TransactionInformation.All(t => t.InstructedAgent is null)
            )
            .WithName("InstructedAgentRule")
            .WithMessage(
                "PaymentReturnV15: if GroupHeader.InstructedAgent is present, every "
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
                "PaymentReturnV15: if GroupHeader.InstructingAgent is present, every "
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
                "PaymentReturnV15: if GroupHeader.InterbankSettlementDate is present, "
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
                "PaymentReturnV15: if GroupHeader.InterbankSettlementDate is absent, "
                    + "every TransactionInformation[*].InterbankSettlementDate must be present "
                    + "(TransactionInterbankSettlementDateRule)."
            );

        // ── GroupReturnAndNumberOfTransactionsRule ───────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.GroupReturn?.BoolValue != false
                || (int.TryParse((string)x.GroupHeader.NumberOfTransactions, out var n)
                    && n == x.TransactionInformation.Count)
            )
            .WithName("GroupReturnAndNumberOfTransactionsRule")
            .WithMessage(
                "PaymentReturnV15: if GroupHeader.GroupReturn is false, "
                    + "GroupHeader.NumberOfTransactions must equal the count of TransactionInformation "
                    + "(GroupReturnAndNumberOfTransactionsRule)."
            );

        // ── TotalReturnedInterbankSettlementAmountRule ───────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.TotalReturnedInterbankSettlementAmount is null
                || x.TransactionInformation.All(t =>
                    t.ReturnedInterbankSettlementAmount.Currency
                    == x.GroupHeader.TotalReturnedInterbankSettlementAmount.Currency
                )
            )
            .WithName("TotalReturnedInterbankSettlementAmountRule")
            .WithMessage(
                "PaymentReturnV15: if GroupHeader.TotalReturnedInterbankSettlementAmount "
                    + "is present, every TransactionInformation[*].ReturnedInterbankSettlementAmount "
                    + "must share its currency (TotalReturnedInterbankSettlementAmountRule)."
            );

        // ── TotalReturnedInterbankSettlementAmountAndSumRule ─────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.TotalReturnedInterbankSettlementAmount is null
                || x.GroupHeader.TotalReturnedInterbankSettlementAmount.Amount
                    == x.TransactionInformation.Sum(t => t.ReturnedInterbankSettlementAmount.Amount)
            )
            .WithName("TotalReturnedInterbankSettlementAmountAndSumRule")
            .WithMessage(
                "PaymentReturnV15: GroupHeader.TotalReturnedInterbankSettlementAmount, "
                    + "when present, must equal the sum of all "
                    + "TransactionInformation[*].ReturnedInterbankSettlementAmount "
                    + "(TotalReturnedInterbankSettlementAmountAndSumRule)."
            );

        // ── OriginalGroupInformationRule ──────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformation is null
                || x.TransactionInformation.All(t => t.OriginalGroupInformation is null)
            )
            .WithName("OriginalGroupInformationRule")
            .WithMessage(
                "PaymentReturnV15: if (message-level) OriginalGroupInformation is present, "
                    + "every TransactionInformation[*].OriginalGroupInformation must be absent "
                    + "(OriginalGroupInformationRule)."
            );

        // ── PaymentTypeInformationRule ────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.PaymentTypeInformation is null
                || x.TransactionInformation.All(t => t.PaymentTypeInformation is null)
            )
            .WithName("PaymentTypeInformationRule")
            .WithMessage(
                "PaymentReturnV15: if GroupHeader.PaymentTypeInformation is present, every "
                    + "TransactionInformation[*].PaymentTypeInformation must be absent (PaymentTypeInformationRule)."
            );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentReturnV15Validator()
        : this(
            new GroupHeader123Validator(),
            new OriginalGroupHeader19Validator(),
            new PaymentTransaction168Validator(),
            new SupplementaryData1Validator()
        ) { }
}
