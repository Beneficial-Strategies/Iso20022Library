// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="RegulatoryReportingType1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _JVOXAHeLEfCdoODv2ypKfw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Choice between a code or proprietary format for regulatory reporting type.
/// <list type="table">
///   <item><term><see cref="Choices.RegulatoryReportingType1Choice.Code"/></term><description>Value: ExternalRegulatoryReportingType1Code (required 1..1) — checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> via <see cref="ExternalRegulatoryReportingType1CodeValidator"/></description></item>
///   <item><term><see cref="Choices.RegulatoryReportingType1Choice.Proprietary"/></term><description>Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below.
///
/// Dependency injection: the <c>Code</c> variant's <c>Value</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class RegulatoryReportingType1Choice_Validator : AbstractValidator<RegulatoryReportingType1Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Code</c> variant's <c>Value</c> — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="codeValueValidator">
    /// Validator for <see cref="Choices.RegulatoryReportingType1Choice.Code"/>'s required <c>Value</c>
    /// (ExternalRegulatoryReportingType1Code, 1..1).
    /// </param>
    public RegulatoryReportingType1Choice_Validator(
        IValidator<ExternalRegulatoryReportingType1Code> codeValueValidator
    )
    {
        var codeVariantValidator = new InlineValidator<Choices.RegulatoryReportingType1Choice.Code>();
        codeVariantValidator.RuleFor(x => x.Value).SetValidator(codeValueValidator!);

        // Proprietary variant: Value is fully struct-enforced (Max35Text) — no rules needed, so
        // no InlineValidator is registered for it; SetInheritanceValidator leaves an unregistered
        // variant type as always-valid by design (see Party50Choice_Validator's own remarks for
        // the general pattern).

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(codeVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Code</c> variant's
    /// <c>Value</c> is validated by its own default validator
    /// (<see cref="ExternalRegulatoryReportingType1CodeValidator"/>). Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public RegulatoryReportingType1Choice_Validator()
        : this(new ExternalRegulatoryReportingType1CodeValidator()) { }
}
