// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

/// <summary>
/// Validates <see cref="FinancialInstitutionCreditTransferV13"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pacs.009.001.13 (b70980f0-c5be-4e42-bb84-24f01b90e88e), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). Seventh message built for the pacs
/// business area — the interbank financial-institution-to-financial-institution credit transfer
/// (used for cover payments and direct FI-to-FI transfers).
///
/// The FinancialInstitutionCreditTransfer message is sent by a debtor financial institution to a
/// creditor financial institution, directly or through other agents and/or a payment clearing and
/// settlement system. It is used to move funds from a debtor account to a creditor, where both
/// debtor and creditor are financial institutions.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader131 — required (1..1)</description></item>
///   <item><term>CreditTransferTransactionInformation</term><description>CreditTransferTransaction79 collection — optional (0..&#8734;)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// Constraints (from spec) — 8 of 9 enforced here (1 is not independently enforceable, noted
/// below). Same shape as <c>FIToFICustomerCreditTransferV14Validator</c>'s constraint set, minus
/// <c>GroupHeaderExpiryDateTimeRule</c>'s nested-field wrinkle (here it targets
/// <c>CreditTransferTransactionInformation.ExpiryDateTime</c> directly, not
/// <c>.AdditionalDateTime.ExpiryDateTime</c>):
/// <list type="bullet">
///   <item>
///     <term>InstructedAgentRule</term>
///     <description>If GroupHeader.InstructedAgent is present, then every CreditTransferTransactionInformation[*].InstructedAgent must be absent.</description>
///   </item>
///   <item>
///     <term>InstructingAgentRule</term>
///     <description>If GroupHeader.InstructingAgent is present, then every CreditTransferTransactionInformation[*].InstructingAgent must be absent.</description>
///   </item>
///   <item>
///     <term>TotalInterbankSettlementAmountRule</term>
///     <description>If GroupHeader.TotalInterbankSettlementAmount is present, every CreditTransferTransactionInformation[*].InterbankSettlementAmount must share its currency.</description>
///   </item>
///   <item>
///     <term>TotalInterbankSettlementAmountAndSumRule</term>
///     <description>GroupHeader.TotalInterbankSettlementAmount, when present, must equal the sum of all CreditTransferTransactionInformation[*].InterbankSettlementAmount.</description>
///   </item>
///   <item>
///     <term>GroupHeaderInterbankSettlementDateRule</term>
///     <description>If GroupHeader.InterbankSettlementDate is present, every CreditTransferTransactionInformation[*].InterbankSettlementDate must be absent.</description>
///   </item>
///   <item>
///     <term>TransactionInterbankSettlementDateRule</term>
///     <description>If GroupHeader.InterbankSettlementDate is absent, every CreditTransferTransactionInformation[*].InterbankSettlementDate must be present.</description>
///   </item>
///   <item>
///     <term>PaymentTypeInformationRule</term>
///     <description>If GroupHeader.PaymentTypeInformation is present, every CreditTransferTransactionInformation[*].PaymentTypeInformation must be absent.</description>
///   </item>
///   <item>
///     <term>GroupHeaderExpiryDateTimeRule</term>
///     <description>If GroupHeader.ExpiryDateTime is present, every CreditTransferTransactionInformation[*].ExpiryDateTime must be absent.</description>
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
/// Dependency injection: <c>GroupHeader</c>, <c>CreditTransferTransactionInformation</c> (each
/// item), and <c>SupplementaryData</c> (each item) are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class FinancialInstitutionCreditTransferV13Validator
    : AbstractValidator<FinancialInstitutionCreditTransferV13>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public FinancialInstitutionCreditTransferV13Validator(
        IValidator<GroupHeader131> groupHeaderValidator,
        IValidator<CreditTransferTransaction79> creditTransferTransactionInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);

        RuleForEach(x => x.CreditTransferTransactionInformation)
            .SetValidator(creditTransferTransactionInformationValidator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);

        // ── InstructedAgentRule ───────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InstructedAgent is null
                || x.CreditTransferTransactionInformation.All(t => t.InstructedAgent is null)
            )
            .WithName("InstructedAgentRule")
            .WithMessage(
                "FinancialInstitutionCreditTransferV13: if GroupHeader.InstructedAgent is "
                    + "present, every CreditTransferTransactionInformation[*].InstructedAgent "
                    + "must be absent (InstructedAgentRule)."
            );

        // ── InstructingAgentRule ──────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InstructingAgent is null
                || x.CreditTransferTransactionInformation.All(t => t.InstructingAgent is null)
            )
            .WithName("InstructingAgentRule")
            .WithMessage(
                "FinancialInstitutionCreditTransferV13: if GroupHeader.InstructingAgent is "
                    + "present, every CreditTransferTransactionInformation[*].InstructingAgent "
                    + "must be absent (InstructingAgentRule)."
            );

        // ── TotalInterbankSettlementAmountRule ───────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.TotalInterbankSettlementAmount is null
                || x.CreditTransferTransactionInformation.All(t =>
                    t.InterbankSettlementAmount.Currency == x.GroupHeader.TotalInterbankSettlementAmount.Currency
                )
            )
            .WithName("TotalInterbankSettlementAmountRule")
            .WithMessage(
                "FinancialInstitutionCreditTransferV13: if "
                    + "GroupHeader.TotalInterbankSettlementAmount is present, every "
                    + "CreditTransferTransactionInformation[*].InterbankSettlementAmount must "
                    + "share its currency (TotalInterbankSettlementAmountRule)."
            );

        // ── TotalInterbankSettlementAmountAndSumRule ─────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.TotalInterbankSettlementAmount is null
                || x.GroupHeader.TotalInterbankSettlementAmount.Amount
                    == x.CreditTransferTransactionInformation.Sum(t => t.InterbankSettlementAmount.Amount)
            )
            .WithName("TotalInterbankSettlementAmountAndSumRule")
            .WithMessage(
                "FinancialInstitutionCreditTransferV13: GroupHeader.TotalInterbankSettlementAmount, "
                    + "when present, must equal the sum of all "
                    + "CreditTransferTransactionInformation[*].InterbankSettlementAmount "
                    + "(TotalInterbankSettlementAmountAndSumRule)."
            );

        // ── GroupHeaderInterbankSettlementDateRule ───────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InterbankSettlementDate is null
                || x.CreditTransferTransactionInformation.All(t => t.InterbankSettlementDate is null)
            )
            .WithName("GroupHeaderInterbankSettlementDateRule")
            .WithMessage(
                "FinancialInstitutionCreditTransferV13: if GroupHeader.InterbankSettlementDate "
                    + "is present, every "
                    + "CreditTransferTransactionInformation[*].InterbankSettlementDate must be "
                    + "absent (GroupHeaderInterbankSettlementDateRule)."
            );

        // ── TransactionInterbankSettlementDateRule ───────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.InterbankSettlementDate is not null
                || x.CreditTransferTransactionInformation.All(t => t.InterbankSettlementDate is not null)
            )
            .WithName("TransactionInterbankSettlementDateRule")
            .WithMessage(
                "FinancialInstitutionCreditTransferV13: if GroupHeader.InterbankSettlementDate "
                    + "is absent, every "
                    + "CreditTransferTransactionInformation[*].InterbankSettlementDate must be "
                    + "present (TransactionInterbankSettlementDateRule)."
            );

        // ── PaymentTypeInformationRule ────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.PaymentTypeInformation is null
                || x.CreditTransferTransactionInformation.All(t => t.PaymentTypeInformation is null)
            )
            .WithName("PaymentTypeInformationRule")
            .WithMessage(
                "FinancialInstitutionCreditTransferV13: if GroupHeader.PaymentTypeInformation "
                    + "is present, every "
                    + "CreditTransferTransactionInformation[*].PaymentTypeInformation must be "
                    + "absent (PaymentTypeInformationRule)."
            );

        // ── GroupHeaderExpiryDateTimeRule ─────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.ExpiryDateTime is null
                || x.CreditTransferTransactionInformation.All(t => t.ExpiryDateTime is null)
            )
            .WithName("GroupHeaderExpiryDateTimeRule")
            .WithMessage(
                "FinancialInstitutionCreditTransferV13: if GroupHeader.ExpiryDateTime is "
                    + "present, every CreditTransferTransactionInformation[*].ExpiryDateTime "
                    + "must be absent (GroupHeaderExpiryDateTimeRule)."
            );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public FinancialInstitutionCreditTransferV13Validator()
        : this(
            new GroupHeader131Validator(),
            new CreditTransferTransaction79Validator(),
            new SupplementaryData1Validator()
        ) { }
}
