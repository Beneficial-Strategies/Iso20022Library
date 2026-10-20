// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="ILimitStructure3Choice"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _64VGkTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Limit details of one or more limits set by the member and managed by the transaction
/// administrator.
/// <list type="table">
///   <item><term><see cref="Choices.LimitStructure3Choice.IAllCurrentLimits"/></term><description>Identifies all the current limits managed by the transaction administrator — Value: LimitIdentification9</description></item>
///   <item><term><see cref="Choices.LimitStructure3Choice.ICurrentLimitIdentification"/></term><description>Identifies one particular current limit — Value: LimitIdentification8</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below — see
/// "Validating polymorphic choice types" in the FluentValidation project's own <c>CLAUDE.md</c>.
///
/// Dependency injection: each variant's nested <c>Value</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class LimitStructure3Choice_Validator : AbstractValidator<ILimitStructure3Choice>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for each variant's nested <c>Value</c> — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="allCurrentLimitsValueValidator">
    /// Validator for <see cref="Choices.LimitStructure3Choice.IAllCurrentLimits"/>'s <c>Value</c>
    /// (LimitIdentification9).
    /// </param>
    /// <param name="currentLimitIdentificationValueValidator">
    /// Validator for <see cref="Choices.LimitStructure3Choice.ICurrentLimitIdentification"/>'s <c>Value</c>
    /// (LimitIdentification8).
    /// </param>
    public LimitStructure3Choice_Validator(
        IValidator<ILimitIdentification9> allCurrentLimitsValueValidator,
        IValidator<ILimitIdentification8> currentLimitIdentificationValueValidator
    )
    {
        var allCurrentLimitsVariantValidator = new InlineValidator<Choices.LimitStructure3Choice.IAllCurrentLimits>();
        allCurrentLimitsVariantValidator.RuleFor(x => x.Value).SetValidator(allCurrentLimitsValueValidator);

        var currentLimitIdentificationVariantValidator =
            new InlineValidator<Choices.LimitStructure3Choice.ICurrentLimitIdentification>();
        currentLimitIdentificationVariantValidator
            .RuleFor(x => x.Value)
            .SetValidator(currentLimitIdentificationValueValidator);

        this.SetVariantValidators(v =>
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
