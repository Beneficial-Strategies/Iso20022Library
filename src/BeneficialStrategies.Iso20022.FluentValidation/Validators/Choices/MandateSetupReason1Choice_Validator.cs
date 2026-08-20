// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="MandateSetupReason1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _iQq8ND2OEeS6DKIV6SF6gw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the reason for the setup of the mandate.
/// <list type="table">
///   <item><term><see cref="MandateSetupReason1Choice.Code"/></term><description>Reason for the setup of the mandate, as published in an external mandate setup reason code list — Value: ExternalMandateSetupReason1Code</description></item>
///   <item><term><see cref="MandateSetupReason1Choice.Proprietary"/></term><description>Specifies a character string with a maximum length of 70 characters — Value: Max70Text (fully struct-enforced, no further rule needed)</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below.
///
/// Dependency injection: the <c>Code</c> variant's <c>Value</c> — an
/// <see cref="ExternalMandateSetupReason1Code"/> — is checked against an injected
/// <see cref="IExternalCodeRegistry{TCode}"/> (via <see cref="ExternalMandateSetupReason1CodeValidator"/>)
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class MandateSetupReason1Choice_Validator : AbstractValidator<MandateSetupReason1Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Code</c> variant's <c>Value</c> — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="codeValueValidator">
    /// Validator for <see cref="MandateSetupReason1Choice.Code"/>'s <c>Value</c>
    /// (ExternalMandateSetupReason1Code).
    /// </param>
    public MandateSetupReason1Choice_Validator(
        IValidator<ExternalMandateSetupReason1Code> codeValueValidator
    )
    {
        // Proprietary variant: Value is fully struct-enforced (Max70Text) — no rules needed, so
        // no InlineValidator is registered for it; SetInheritanceValidator leaves an unregistered
        // variant type as always-valid by design (see Party50Choice_Validator's own remarks).

        var codeVariantValidator = new InlineValidator<Choices.MandateSetupReason1Choice.Code>();
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
    /// (<see cref="ExternalMandateSetupReason1CodeValidator"/>). Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public MandateSetupReason1Choice_Validator()
        : this(new ExternalMandateSetupReason1CodeValidator()) { }
}
