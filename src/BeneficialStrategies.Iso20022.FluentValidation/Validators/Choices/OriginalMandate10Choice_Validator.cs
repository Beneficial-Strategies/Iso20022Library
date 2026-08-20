// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="OriginalMandate10Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _yNcaETEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Specifies the mandate that is being accepted.
/// <list type="table">
///   <item><term><see cref="OriginalMandate10Choice.OriginalMandateIdentification"/></term><description>Unique identification, as assigned by the responsible party or agent, to unambiguously identify the original mandate — Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="OriginalMandate10Choice.OriginalMandate"/></term><description>Provides the original mandate data — Value: Mandate20</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below.
///
/// Dependency injection: the <c>OriginalMandate</c> variant's <c>Value</c> is validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class OriginalMandate10Choice_Validator : AbstractValidator<OriginalMandate10Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>OriginalMandate</c> variant's <c>Value</c> — e.g. resolved from a DI container
    /// — instead of this type constructing its own.
    /// </summary>
    /// <param name="originalMandateValueValidator">
    /// Validator for <see cref="OriginalMandate10Choice.OriginalMandate"/>'s <c>Value</c>
    /// (Mandate20).
    /// </param>
    public OriginalMandate10Choice_Validator(IValidator<Mandate20> originalMandateValueValidator)
    {
        // OriginalMandateIdentification variant: Value is fully struct-enforced (Max35Text) — no
        // rules needed, so no InlineValidator is registered for it; SetInheritanceValidator
        // leaves an unregistered variant type as always-valid by design (see
        // Party50Choice_Validator's own remarks for the general pattern).

        var originalMandateVariantValidator =
            new InlineValidator<Choices.OriginalMandate10Choice.OriginalMandate>();
        originalMandateVariantValidator
            .RuleFor(x => x.Value)
            .SetValidator(originalMandateValueValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(originalMandateVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>OriginalMandate</c>
    /// variant's <c>Value</c> is validated by its own default validator
    /// (<see cref="Mandate20Validator"/>). Convenience constructor for callers not using a DI
    /// container.
    /// </summary>
    public OriginalMandate10Choice_Validator()
        : this(new Mandate20Validator()) { }
}
