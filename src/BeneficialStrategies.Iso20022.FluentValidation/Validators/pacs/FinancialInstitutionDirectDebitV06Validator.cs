// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

/// <summary>
/// Validates <see cref="FinancialInstitutionDirectDebitV06"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pacs.010.001.06 (_R3LnHzEZEe6kQ-WGAhcVPQ), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). Second message built for the pacs
/// business area.
///
/// The FinancialInstitutionDirectDebit message is sent by an exchange or clearing house, or a
/// financial institution, directly or through another agent, to the DebtorAgent. It is used to
/// instruct the DebtorAgent to move funds from one or more debtor(s) account(s) to one or more
/// creditor(s), where both debtor and creditor are financial institutions.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader119 — required (1..1)</description></item>
///   <item><term>CreditInstruction</term><description>CreditTransferTransaction66 collection — required, min 1 (1..&#8734;) per MCP's <c>minOccurs=1</c> on this building block</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// Constraints (from spec):
/// <list type="bullet">
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
/// Known model defect: <c>CreditInstruction</c> is <c>ValueList&lt;T&gt; = []</c>, which allows an
/// empty collection at the C# level even though the spec requires Min=1..&#8734;. Enforced here via
/// an explicit <c>NotEmpty</c> rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// Dependency injection: <c>GroupHeader</c>, <c>CreditInstruction</c>, and <c>SupplementaryData</c>
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — see the two constructors below.
/// </remarks>
public class FinancialInstitutionDirectDebitV06Validator : AbstractValidator<FinancialInstitutionDirectDebitV06>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public FinancialInstitutionDirectDebitV06Validator(
        IValidator<GroupHeader119> groupHeaderValidator,
        IValidator<CreditTransferTransaction66> creditInstructionValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);

        RuleFor(x => x.CreditInstruction)
            .NotEmpty()
            .WithMessage(
                "FinancialInstitutionDirectDebitV06.CreditInstruction must contain at least one element (1..∞)."
            );
        RuleForEach(x => x.CreditInstruction).SetValidator(creditInstructionValidator!);

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public FinancialInstitutionDirectDebitV06Validator()
        : this(
            new GroupHeader119Validator(),
            new CreditTransferTransaction66Validator(),
            new SupplementaryData1Validator()
        ) { }
}
