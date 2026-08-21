// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

/// <summary>
/// Validates <see cref="CreditorPaymentActivationRequestV12"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pain.013.001.12 (d2b0673a-1f10-4086-ad39-b4f95fef2cb5), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// The CreditorPaymentActivationRequest message is sent by the Creditor sending party to the
/// Debtor receiving party, directly or through agents. It is used by a Creditor to request
/// movement of funds from the debtor account to a creditor.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader112 — required (1..1)</description></item>
///   <item><term>PaymentInformation</term><description>PaymentInstruction48 collection — required, min 1 (1..n) per MCP's <c>minOccurs=1</c> on this building block</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..n)</description></item>
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
///
/// Known test-coverage gap (2026-08-21): the <c>PaymentInformation</c> minimum-count rule is
/// genuinely proven by the test suite (<c>EmptyPaymentInformation_HasValidationError</c>), but
/// the <c>SetValidator</c> dispatch to <see cref="GroupHeader112Validator"/> and
/// <see cref="PaymentInstruction48Validator"/> is not — the happy-path test's message content is
/// minimal and does not exercise either nested validator's failure modes. See those types' own
/// remarks for the same gap propagating further down the graph.
/// </remarks>
public class CreditorPaymentActivationRequestV12Validator : AbstractValidator<CreditorPaymentActivationRequestV12>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CreditorPaymentActivationRequestV12Validator(
        IValidator<GroupHeader112> groupHeaderValidator,
        IValidator<PaymentInstruction48> paymentInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);

        RuleFor(x => x.PaymentInformation)
            .NotEmpty()
            .WithMessage(
                "CreditorPaymentActivationRequestV12.PaymentInformation must contain at least one element (1..∞)."
            );
        RuleForEach(x => x.PaymentInformation).SetValidator(paymentInformationValidator!);

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CreditorPaymentActivationRequestV12Validator()
        : this(
            new GroupHeader112Validator(),
            new PaymentInstruction48Validator(),
            new SupplementaryData1Validator()
        ) { }
}
