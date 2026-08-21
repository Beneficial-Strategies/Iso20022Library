// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

/// <summary>
/// Validates <see cref="CustomerDirectDebitInitiationV12"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pain.008.001.12 (7869e710-db06-4132-848e-539312ac3db9), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// The CustomerDirectDebitInitiation message is sent by the initiating party to the forwarding
/// agent or creditor agent. It is used to request single or bulk collection(s) of funds from one
/// or various debtor's account(s) for a creditor.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader118 — required (1..1)</description></item>
///   <item><term>PaymentInformation</term><description>PaymentInstruction50 collection — required, min 1 (1..n) per MCP's <c>minOccurs=1</c> on this building block</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..n)</description></item>
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
/// Known model defect: <c>PaymentInformation</c> is <c>ValueList&lt;T&gt; = []</c>, which allows an
/// empty collection at the C# level even though the spec requires Min=1..&#8734;. Enforced here via
/// an explicit <c>NotEmpty</c> rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// Dependency injection: <c>GroupHeader</c>, <c>PaymentInformation</c>, and
/// <c>SupplementaryData</c> are each validated by an injected <see cref="IValidator{T}"/> rather
/// than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class CustomerDirectDebitInitiationV12Validator : AbstractValidator<CustomerDirectDebitInitiationV12>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CustomerDirectDebitInitiationV12Validator(
        IValidator<GroupHeader118> groupHeaderValidator,
        IValidator<PaymentInstruction50> paymentInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);

        RuleFor(x => x.PaymentInformation)
            .NotEmpty()
            .WithMessage(
                "CustomerDirectDebitInitiationV12.PaymentInformation must contain at least one element (1..∞)."
            );
        RuleForEach(x => x.PaymentInformation).SetValidator(paymentInformationValidator!);

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CustomerDirectDebitInitiationV12Validator()
        : this(
            new GroupHeader118Validator(),
            new PaymentInstruction50Validator(),
            new SupplementaryData1Validator()
        ) { }
}
