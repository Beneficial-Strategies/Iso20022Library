// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

/// <summary>
/// Validates <see cref="FIToFICustomerDirectDebitV12"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pacs.003.001.12 (c2cf0163-0762-45bc-8280-200f601fb57e), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-26). Eighth message built for the pacs
/// business area.
///
/// The FinancialInstitutionToFinancialInstitutionCustomerDirectDebit message is sent by the
/// creditor agent to the debtor agent, directly or through other agents and/or a payment clearing
/// and settlement system. It is used to collect funds from a debtor account for a creditor.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader125 — required (1..1)</description></item>
///   <item><term>DirectDebitTransactionInformation</term><description>DirectDebitTransactionInformation35 collection — optional (0..&#8734;)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// Constraints (from spec) — 6 of 7 enforced here (1 is not independently enforceable, noted
/// below). Same shape as <c>FIToFICustomerCreditTransferV14Validator</c>'s constraint set, minus
/// <c>GroupHeaderExpiryDateTimeRule</c> and <c>NumberOfTransactionsAndCreditTransfersRule</c>,
/// which this message version doesn't declare:
/// <list type="bullet">
///   <item>
///     <term>InstructedAgentRule</term>
///     <description>If GroupHeader.InstructedAgent is present, then every DirectDebitTransactionInformation[*].InstructedAgent must be absent.</description>
///   </item>
///   <item>
///     <term>InstructingAgentRule</term>
///     <description>If GroupHeader.InstructingAgent is present, then every DirectDebitTransactionInformation[*].InstructingAgent must be absent.</description>
///   </item>
///   <item>
///     <term>TotalInterbankSettlementAmountRule</term>
///     <description>If GroupHeader.TotalInterbankSettlementAmount is present, every DirectDebitTransactionInformation[*].InterbankSettlementAmount must share its currency.</description>
///   </item>
///   <item>
///     <term>TotalInterbankSettlementAmountAndSumRule</term>
///     <description>GroupHeader.TotalInterbankSettlementAmount, when present, must equal the sum of all DirectDebitTransactionInformation[*].InterbankSettlementAmount.</description>
///   </item>
///   <item>
///     <term>GroupHeaderInterbankSettlementDateRule</term>
///     <description>If GroupHeader.InterbankSettlementDate is present, every DirectDebitTransactionInformation[*].InterbankSettlementDate must be absent.</description>
///   </item>
///   <item>
///     <term>TransactionInterbankSettlementDateRule</term>
///     <description>If GroupHeader.InterbankSettlementDate is absent, every DirectDebitTransactionInformation[*].InterbankSettlementDate must be present.</description>
///   </item>
///   <item>
///     <term>PaymentTypeInformationRule</term>
///     <description>If GroupHeader.PaymentTypeInformation is present, every DirectDebitTransactionInformation[*].PaymentTypeInformation must be absent.</description>
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
/// Dependency injection: <c>GroupHeader</c>, <c>DirectDebitTransactionInformation</c> (each
/// item), and <c>SupplementaryData</c> (each item) are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class FIToFICustomerDirectDebitV12Validator : AbstractValidator<FIToFICustomerDirectDebitV12>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public FIToFICustomerDirectDebitV12Validator(
        IValidator<GroupHeader125> groupHeaderValidator,
        IValidator<DirectDebitTransactionInformation35> directDebitTransactionInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);

        RuleForEach(x => x.DirectDebitTransactionInformation)
            .SetValidator(directDebitTransactionInformationValidator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);

        // ── InstructedAgentRule ───────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InstructedAgent is null
                || x.DirectDebitTransactionInformation.All(t => t.InstructedAgent is null)
            )
            .WithName("InstructedAgentRule")
            .WithMessage(
                "FIToFICustomerDirectDebitV12: if GroupHeader.InstructedAgent is present, every "
                    + "DirectDebitTransactionInformation[*].InstructedAgent must be absent (InstructedAgentRule)."
            );

        // ── InstructingAgentRule ──────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InstructingAgent is null
                || x.DirectDebitTransactionInformation.All(t => t.InstructingAgent is null)
            )
            .WithName("InstructingAgentRule")
            .WithMessage(
                "FIToFICustomerDirectDebitV12: if GroupHeader.InstructingAgent is present, every "
                    + "DirectDebitTransactionInformation[*].InstructingAgent must be absent (InstructingAgentRule)."
            );

        // ── TotalInterbankSettlementAmountRule ───────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.TotalInterbankSettlementAmount is null
                || x.DirectDebitTransactionInformation.All(t =>
                    t.InterbankSettlementAmount.Currency == x.GroupHeader.TotalInterbankSettlementAmount.Currency
                )
            )
            .WithName("TotalInterbankSettlementAmountRule")
            .WithMessage(
                "FIToFICustomerDirectDebitV12: if GroupHeader.TotalInterbankSettlementAmount is "
                    + "present, every DirectDebitTransactionInformation[*].InterbankSettlementAmount "
                    + "must share its currency (TotalInterbankSettlementAmountRule)."
            );

        // ── TotalInterbankSettlementAmountAndSumRule ─────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.TotalInterbankSettlementAmount is null
                || x.GroupHeader.TotalInterbankSettlementAmount.Amount
                    == x.DirectDebitTransactionInformation.Sum(t => t.InterbankSettlementAmount.Amount)
            )
            .WithName("TotalInterbankSettlementAmountAndSumRule")
            .WithMessage(
                "FIToFICustomerDirectDebitV12: GroupHeader.TotalInterbankSettlementAmount, when "
                    + "present, must equal the sum of all "
                    + "DirectDebitTransactionInformation[*].InterbankSettlementAmount "
                    + "(TotalInterbankSettlementAmountAndSumRule)."
            );

        // ── GroupHeaderInterbankSettlementDateRule ───────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InterbankSettlementDate is null
                || x.DirectDebitTransactionInformation.All(t => t.InterbankSettlementDate is null)
            )
            .WithName("GroupHeaderInterbankSettlementDateRule")
            .WithMessage(
                "FIToFICustomerDirectDebitV12: if GroupHeader.InterbankSettlementDate is "
                    + "present, every DirectDebitTransactionInformation[*].InterbankSettlementDate "
                    + "must be absent (GroupHeaderInterbankSettlementDateRule)."
            );

        // ── TransactionInterbankSettlementDateRule ───────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InterbankSettlementDate is not null
                || x.DirectDebitTransactionInformation.All(t => t.InterbankSettlementDate is not null)
            )
            .WithName("TransactionInterbankSettlementDateRule")
            .WithMessage(
                "FIToFICustomerDirectDebitV12: if GroupHeader.InterbankSettlementDate is absent, "
                    + "every DirectDebitTransactionInformation[*].InterbankSettlementDate must be "
                    + "present (TransactionInterbankSettlementDateRule)."
            );

        // ── PaymentTypeInformationRule ────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.PaymentTypeInformation is null
                || x.DirectDebitTransactionInformation.All(t => t.PaymentTypeInformation is null)
            )
            .WithName("PaymentTypeInformationRule")
            .WithMessage(
                "FIToFICustomerDirectDebitV12: if GroupHeader.PaymentTypeInformation is present, "
                    + "every DirectDebitTransactionInformation[*].PaymentTypeInformation must be "
                    + "absent (PaymentTypeInformationRule)."
            );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public FIToFICustomerDirectDebitV12Validator()
        : this(
            new GroupHeader125Validator(),
            new DirectDebitTransactionInformation35Validator(),
            new SupplementaryData1Validator()
        ) { }
}
