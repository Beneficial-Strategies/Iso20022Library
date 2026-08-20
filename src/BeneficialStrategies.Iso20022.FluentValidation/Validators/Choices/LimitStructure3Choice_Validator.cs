// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="LimitStructure3Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _64VGkTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Limit details of one or more limits set by the member and managed by the transaction
/// administrator.
/// <list type="table">
///   <item><term><see cref="LimitStructure3Choice.AllCurrentLimits"/></term><description>Identifies all the current limits managed by the transaction administrator — Value: LimitIdentification9</description></item>
///   <item><term><see cref="LimitStructure3Choice.CurrentLimitIdentification"/></term><description>Identifies one particular current limit — Value: LimitIdentification8</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below — see
/// "Validating polymorphic choice types" in the FluentValidation project's own <c>CLAUDE.md</c>.
///
/// Dependency injection: each variant's nested <c>Value</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class LimitStructure3Choice_Validator : AbstractValidator<LimitStructure3Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for each variant's nested <c>Value</c> — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="allCurrentLimitsValueValidator">
    /// Validator for <see cref="LimitStructure3Choice.AllCurrentLimits"/>'s <c>Value</c>
    /// (LimitIdentification9).
    /// </param>
    /// <param name="currentLimitIdentificationValueValidator">
    /// Validator for <see cref="LimitStructure3Choice.CurrentLimitIdentification"/>'s <c>Value</c>
    /// (LimitIdentification8).
    /// </param>
    public LimitStructure3Choice_Validator(
        IValidator<LimitIdentification9> allCurrentLimitsValueValidator,
        IValidator<LimitIdentification8> currentLimitIdentificationValueValidator
    )
    {
        var allCurrentLimitsVariantValidator = new InlineValidator<Choices.LimitStructure3Choice.AllCurrentLimits>();
        allCurrentLimitsVariantValidator.RuleFor(x => x.Value).SetValidator(allCurrentLimitsValueValidator);

        var currentLimitIdentificationVariantValidator =
            new InlineValidator<Choices.LimitStructure3Choice.CurrentLimitIdentification>();
        currentLimitIdentificationVariantValidator
            .RuleFor(x => x.Value)
            .SetValidator(currentLimitIdentificationValueValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(allCurrentLimitsVariantValidator);
                v.Add(currentLimitIdentificationVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: each variant's nested <c>Value</c>
    /// is validated by its own default validator (<see cref="LimitIdentification9Validator"/>,
    /// <see cref="LimitIdentification8Validator"/>). Convenience constructor for callers not
    /// using a DI container.
    /// </summary>
    public LimitStructure3Choice_Validator()
        : this(new LimitIdentification9Validator(), new LimitIdentification8Validator()) { }
}
