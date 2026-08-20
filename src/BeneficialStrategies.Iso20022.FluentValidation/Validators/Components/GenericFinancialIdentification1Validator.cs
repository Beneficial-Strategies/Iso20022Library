// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GenericFinancialIdentification1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _QALkM9p-Ed-ak6NoX_4Aeg_-2141717394
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Information related to an identification of a financial institution.
/// <list type="table">
///   <item><term>Identification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>SchemeName</term><description>FinancialIdentificationSchemeName1Choice_ — optional (0..1)</description></item>
///   <item><term>Issuer</term><description>Max35Text — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>SchemeName</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class GenericFinancialIdentification1Validator
    : AbstractValidator<GenericFinancialIdentification1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>SchemeName</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="schemeNameValidator">
    /// Validator for the optional <c>SchemeName</c> building block
    /// (FinancialIdentificationSchemeName1Choice_, 0..1) — only invoked when present.
    /// </param>
    public GenericFinancialIdentification1Validator(
        IValidator<FinancialIdentificationSchemeName1Choice_> schemeNameValidator
    )
    {
        // Identification: Max35Text, required (1..1) and already `required` C# property — length
        // [1..35] enforced by struct constructor.
        // Issuer: Max35Text, optional — length [1..35] enforced by struct constructor.

        When(
            x => x.SchemeName is not null,
            () => RuleFor(x => x.SchemeName).SetValidator(schemeNameValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>SchemeName</c> building
    /// block is validated by its own default validator
    /// (<see cref="FinancialIdentificationSchemeName1Choice_Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public GenericFinancialIdentification1Validator()
        : this(new FinancialIdentificationSchemeName1Choice_Validator()) { }
}
