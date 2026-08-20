// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GenericPersonIdentification2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: __Aaz9TFLEe651u5xu3f5iw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Information related to an identification of a person.
/// <list type="table">
///   <item><term>Identification</term><description>Max256Text — required (1..1)</description></item>
///   <item><term>SchemeName</term><description>PersonIdentificationSchemeName1Choice_ — optional (0..1)</description></item>
///   <item><term>Issuer</term><description>Max35Text — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>SchemeName</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class GenericPersonIdentification2Validator : AbstractValidator<GenericPersonIdentification2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>SchemeName</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="schemeNameValidator">
    /// Validator for the optional <c>SchemeName</c> building block
    /// (PersonIdentificationSchemeName1Choice_, 0..1) — only invoked when present.
    /// </param>
    public GenericPersonIdentification2Validator(
        IValidator<PersonIdentificationSchemeName1Choice_> schemeNameValidator
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
    /// (<see cref="PersonIdentificationSchemeName1Choice_Validator"/>). Convenience constructor
    /// for callers not using a DI container.
    /// </summary>
    public GenericPersonIdentification2Validator()
        : this(new PersonIdentificationSchemeName1Choice_Validator()) { }
}
