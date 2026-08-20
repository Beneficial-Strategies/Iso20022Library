// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="FinancialIdentificationSchemeName1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _QALkMNp-Ed-ak6NoX_4Aeg_-2021925461
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Sets of elements to identify a name of the organisation identification scheme.
/// <list type="table">
///   <item><term><see cref="FinancialIdentificationSchemeName1Choice.Code"/></term><description>Name of the identification scheme, in a coded form as published in an external list — Value: ExternalFinancialInstitutionIdentification1Code</description></item>
///   <item><term><see cref="FinancialIdentificationSchemeName1Choice.Proprietary"/></term><description>Name of the identification scheme, in a free text form — Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below.
///
/// Dependency injection: the <c>Code</c> variant's <c>Value</c> — an
/// <see cref="ExternalFinancialInstitutionIdentification1Code"/> — is checked against an injected
/// <see cref="IExternalCodeRegistry{TCode}"/> (via <see cref="ExternalFinancialInstitutionIdentification1CodeValidator"/>)
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class FinancialIdentificationSchemeName1Choice_Validator
    : AbstractValidator<FinancialIdentificationSchemeName1Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Code</c> variant's <c>Value</c> — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="codeValueValidator">
    /// Validator for <see cref="FinancialIdentificationSchemeName1Choice.Code"/>'s <c>Value</c>
    /// (ExternalFinancialInstitutionIdentification1Code).
    /// </param>
    public FinancialIdentificationSchemeName1Choice_Validator(
        IValidator<ExternalFinancialInstitutionIdentification1Code> codeValueValidator
    )
    {
        // Proprietary variant: Value is fully struct-enforced (Max35Text) — no rules needed, so
        // no InlineValidator is registered for it; SetInheritanceValidator leaves an unregistered
        // variant type as always-valid by design (see Party50Choice_Validator's own remarks).

        var codeVariantValidator =
            new InlineValidator<Choices.FinancialIdentificationSchemeName1Choice.Code>();
        codeVariantValidator.RuleFor(x => x.Value).SetValidator(codeValueValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(codeVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Code</c> variant's
    /// <c>Value</c> is validated by its own default validator
    /// (<see cref="ExternalFinancialInstitutionIdentification1CodeValidator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public FinancialIdentificationSchemeName1Choice_Validator()
        : this(new ExternalFinancialInstitutionIdentification1CodeValidator()) { }
}
