// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="StandingOrderOrAll4Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6jk-kTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Characteristics of one or all standing orders set by the member and managed by the transaction
/// administrator.
/// <list type="table">
///   <item><term><see cref="Choices.StandingOrderOrAll4Choice.AllStandingOrders"/></term><description>Identifies all the standing orders managed by the transaction administrator — Value: StandingOrderIdentification9</description></item>
///   <item><term><see cref="Choices.StandingOrderOrAll4Choice.StandingOrder"/></term><description>Identifies one particular standing order — Value: StandingOrderIdentification8</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below — see
/// "Validating polymorphic choice types" in the FluentValidation project's own <c>CLAUDE.md</c>.
///
/// Dependency injection: each variant's nested <c>Value</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class StandingOrderOrAll4Choice_Validator : AbstractValidator<StandingOrderOrAll4Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for each variant's nested <c>Value</c> — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="allStandingOrdersValueValidator">
    /// Validator for <see cref="Choices.StandingOrderOrAll4Choice.AllStandingOrders"/>'s <c>Value</c>
    /// (StandingOrderIdentification9).
    /// </param>
    /// <param name="standingOrderValueValidator">
    /// Validator for <see cref="Choices.StandingOrderOrAll4Choice.StandingOrder"/>'s <c>Value</c>
    /// (StandingOrderIdentification8).
    /// </param>
    public StandingOrderOrAll4Choice_Validator(
        IValidator<StandingOrderIdentification9> allStandingOrdersValueValidator,
        IValidator<StandingOrderIdentification8> standingOrderValueValidator
    )
    {
        var allStandingOrdersVariantValidator =
            new InlineValidator<Choices.StandingOrderOrAll4Choice.AllStandingOrders>();
        allStandingOrdersVariantValidator.RuleFor(x => x.Value).SetValidator(allStandingOrdersValueValidator);

        var standingOrderVariantValidator = new InlineValidator<Choices.StandingOrderOrAll4Choice.StandingOrder>();
        standingOrderVariantValidator.RuleFor(x => x.Value).SetValidator(standingOrderValueValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(allStandingOrdersVariantValidator);
                v.Add(standingOrderVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: each variant's nested <c>Value</c>
    /// is validated by its own default validator
    /// (<see cref="StandingOrderIdentification9Validator"/>,
    /// <see cref="StandingOrderIdentification8Validator"/>). Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public StandingOrderOrAll4Choice_Validator()
        : this(new StandingOrderIdentification9Validator(), new StandingOrderIdentification8Validator()) { }
}
