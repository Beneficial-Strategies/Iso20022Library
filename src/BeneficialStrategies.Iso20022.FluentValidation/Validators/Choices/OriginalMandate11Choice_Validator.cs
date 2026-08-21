// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="OriginalMandate11Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1iUrOzEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the mandate that is being accepted.
/// <list type="table">
///   <item><term><see cref="OriginalMandate11Choice.OriginalMandateIdentification"/></term><description>Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="OriginalMandate11Choice.OriginalMandate"/></term><description>Value: Mandate22</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below. Only the
/// <c>OriginalMandate</c> variant gets an <see cref="InlineValidator{T}"/> — the
/// <c>OriginalMandateIdentification</c> variant's <c>Value</c> is fully struct-enforced, so no
/// validator is registered for it; <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// leaves an unregistered variant type as always-valid by design (see
/// <see cref="Party50Choice_Validator"/>'s own remarks).
///
/// Dependency injection: the <c>OriginalMandate</c> variant's <c>Value</c> is validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class OriginalMandate11Choice_Validator : AbstractValidator<OriginalMandate11Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>OriginalMandate</c> variant's <c>Value</c> — e.g. resolved from a DI container
    /// — instead of this type constructing its own.
    /// </summary>
    /// <param name="originalMandateValueValidator">
    /// Validator for <see cref="OriginalMandate11Choice.OriginalMandate"/>'s <c>Value</c>
    /// (Mandate22).
    /// </param>
    public OriginalMandate11Choice_Validator(IValidator<Mandate22> originalMandateValueValidator)
    {
        var originalMandateVariantValidator = new InlineValidator<Choices.OriginalMandate11Choice.OriginalMandate>();
        originalMandateVariantValidator.RuleFor(x => x.Value).SetValidator(originalMandateValueValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(originalMandateVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>OriginalMandate</c>
    /// variant's <c>Value</c> is validated by its own default validator
    /// (<see cref="Mandate22Validator"/>). Convenience constructor for callers not using a DI
    /// container.
    /// </summary>
    public OriginalMandate11Choice_Validator()
        : this(new Mandate22Validator()) { }
}
