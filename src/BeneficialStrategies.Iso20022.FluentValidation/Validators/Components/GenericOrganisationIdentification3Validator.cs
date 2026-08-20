// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GenericOrganisationIdentification3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _bM2KRzFIEe651u5xu3f5iw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Information related to an identification of an organisation.
/// <list type="table">
///   <item><term>Identification</term><description>Max256Text — required (1..1)</description></item>
///   <item><term>SchemeName</term><description>OrganisationIdentificationSchemeName1Choice_ — optional (0..1)</description></item>
///   <item><term>Issuer</term><description>Max35Text — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>SchemeName</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class GenericOrganisationIdentification3Validator
    : AbstractValidator<GenericOrganisationIdentification3>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>SchemeName</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="schemeNameValidator">
    /// Validator for the optional <c>SchemeName</c> building block
    /// (OrganisationIdentificationSchemeName1Choice_, 0..1) — only invoked when present.
    /// </param>
    public GenericOrganisationIdentification3Validator(
        IValidator<OrganisationIdentificationSchemeName1Choice_> schemeNameValidator
    )
    {
        // Identification: Max256Text, required (1..1) and already `required` C# property —
        // length enforced by struct constructor.
        // Issuer: Max35Text, optional — length [1..35] enforced by struct constructor.

        When(
            x => x.SchemeName is not null,
            () => RuleFor(x => x.SchemeName).SetValidator(schemeNameValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>SchemeName</c> building
    /// block is validated by its own default validator
    /// (<see cref="OrganisationIdentificationSchemeName1Choice_Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public GenericOrganisationIdentification3Validator()
        : this(new OrganisationIdentificationSchemeName1Choice_Validator()) { }
}
