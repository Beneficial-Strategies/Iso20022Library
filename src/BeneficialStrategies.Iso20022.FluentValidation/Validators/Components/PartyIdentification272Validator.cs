// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PartyIdentification272"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _vtFWJTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Specifies the identification of a person or an organisation.
/// <list type="table">
///   <item><term>Name</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>PostalAddress</term><description>PostalAddress27 — optional (0..1)</description></item>
///   <item><term>Identification</term><description>Party52Choice_ — optional (0..1)</description></item>
///   <item><term>CountryOfResidence</term><description>CountryCode — optional (0..1)</description></item>
///   <item><term>ContactDetails</term><description>Contact13 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>ContactDetails</c>, <c>Identification</c>, and <c>PostalAddress</c>
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c>; <c>CountryOfResidence</c> — an ISO 3166 <see cref="CountryCode"/> — is checked
/// against an injected <see cref="IExternalCodeRegistry{TCode}"/> (via
/// <see cref="CountryCodeValidator"/>) — see the two constructors below.
/// </remarks>
public class PartyIdentification272Validator : AbstractValidator<PartyIdentification272>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>ContactDetails</c>, <c>Identification</c>, <c>PostalAddress</c>, and
    /// <c>CountryOfResidence</c> building blocks — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="contactDetailsValidator">
    /// Validator for the optional <c>ContactDetails</c> building block (Contact13, 0..1) — only
    /// invoked when present.
    /// </param>
    /// <param name="identificationValidator">
    /// Validator for the optional <c>Identification</c> building block (Party52Choice_, 0..1) —
    /// only invoked when present.
    /// </param>
    /// <param name="postalAddressValidator">
    /// Validator for the optional <c>PostalAddress</c> building block (PostalAddress27, 0..1) —
    /// only invoked when present.
    /// </param>
    /// <param name="countryOfResidenceValidator">
    /// Validator for the optional <c>CountryOfResidence</c> (CountryCode, 0..1) — only invoked
    /// when present.
    /// </param>
    public PartyIdentification272Validator(
        IValidator<Contact13> contactDetailsValidator,
        IValidator<Party52Choice_> identificationValidator,
        IValidator<PostalAddress27> postalAddressValidator,
        IValidator<CountryCode> countryOfResidenceValidator
    )
    {
        // Name: optional scalar, length enforced by struct constructor — no rule needed.

        When(
            x => x.ContactDetails is not null,
            () => RuleFor(x => x.ContactDetails).SetValidator(contactDetailsValidator!)
        );

        When(
            x => x.Identification is not null,
            () => RuleFor(x => x.Identification).SetValidator(identificationValidator!)
        );

        When(
            x => x.PostalAddress is not null,
            () => RuleFor(x => x.PostalAddress).SetValidator(postalAddressValidator!)
        );

        When(
            x => x.CountryOfResidence is not null,
            () => RuleFor(x => x.CountryOfResidence!.Value).SetValidator(countryOfResidenceValidator)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>ContactDetails</c>,
    /// <c>Identification</c>, <c>PostalAddress</c>, and <c>CountryOfResidence</c> are each
    /// validated by their own default validator (<see cref="Contact13Validator"/>,
    /// <see cref="Party52Choice_Validator"/>, <see cref="PostalAddress27Validator"/>,
    /// <see cref="CountryCodeValidator"/>). Convenience constructor for callers not using a DI
    /// container.
    /// </summary>
    public PartyIdentification272Validator()
        : this(
            new Contact13Validator(),
            new Party52Choice_Validator(),
            new PostalAddress27Validator(),
            new CountryCodeValidator()
        ) { }
}
