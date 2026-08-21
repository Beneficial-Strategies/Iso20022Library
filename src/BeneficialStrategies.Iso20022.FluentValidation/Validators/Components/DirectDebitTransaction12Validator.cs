// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DirectDebitTransaction12"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _wuFgITEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides further specific details on the direct debit transaction and the related mandate.
/// <list type="table">
///   <item><term>CreditorSchemeIdentification</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>MandateRelatedInformation</term><description>MandateRelatedInformation16 — optional (0..1)</description></item>
///   <item><term>PreNotificationDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>PreNotificationIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>CreditorSchemeIdentification</c> and <c>MandateRelatedInformation</c>
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — see the two constructors below.
/// </remarks>
public class DirectDebitTransaction12Validator : AbstractValidator<DirectDebitTransaction12>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public DirectDebitTransaction12Validator(
        IValidator<PartyIdentification272> creditorSchemeIdentificationValidator,
        IValidator<MandateRelatedInformation16> mandateRelatedInformationValidator
    )
    {
        When(
            x => x.CreditorSchemeIdentification is not null,
            () => RuleFor(x => x.CreditorSchemeIdentification).SetValidator(creditorSchemeIdentificationValidator!)
        );
        When(
            x => x.MandateRelatedInformation is not null,
            () => RuleFor(x => x.MandateRelatedInformation).SetValidator(mandateRelatedInformationValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public DirectDebitTransaction12Validator()
        : this(new PartyIdentification272Validator(), new MandateRelatedInformation16Validator()) { }
}
