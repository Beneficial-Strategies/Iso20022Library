// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CreditTransferMandateData1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _EVj2MclqEem0vqvvoqYsqQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides further details related to a credit transfer mandate signed between the creditor and
/// the debtor.
/// <list type="table">
///   <item><term>MandateIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Type</term><description>MandateTypeInformation2 — optional (0..1)</description></item>
///   <item><term>DateOfSignature</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>DateOfVerification</term><description>ISODateTime — optional (0..1), fully struct-enforced</description></item>
///   <item><term>ElectronicSignature</term><description>Max10KBinary — optional (0..1), fully struct-enforced</description></item>
///   <item><term>FirstPaymentDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>FinalPaymentDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Frequency</term><description>Frequency36Choice_ — optional (0..1)</description></item>
///   <item><term>Reason</term><description>MandateSetupReason1Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Type</c>, <c>Frequency</c>, and <c>Reason</c> are each validated by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class CreditTransferMandateData1Validator : AbstractValidator<CreditTransferMandateData1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CreditTransferMandateData1Validator(
        IValidator<MandateTypeInformation2> typeValidator,
        IValidator<Frequency36Choice_> frequencyValidator,
        IValidator<MandateSetupReason1Choice_> reasonValidator
    )
    {
        When(x => x.Type is not null, () => RuleFor(x => x.Type).SetValidator(typeValidator!));
        When(x => x.Frequency is not null, () => RuleFor(x => x.Frequency).SetValidator(frequencyValidator!));
        When(x => x.Reason is not null, () => RuleFor(x => x.Reason).SetValidator(reasonValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CreditTransferMandateData1Validator()
        : this(
            new MandateTypeInformation2Validator(),
            new Frequency36Choice_Validator(),
            new MandateSetupReason1Choice_Validator()
        ) { }
}
