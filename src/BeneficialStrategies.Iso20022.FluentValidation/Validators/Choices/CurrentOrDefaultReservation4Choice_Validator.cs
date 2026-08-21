// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="CurrentOrDefaultReservation4Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _5IwmYTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Current or default reservation set by the member and managed by the transaction administrator.
/// <list type="table">
///   <item><term><see cref="CurrentOrDefaultReservation4Choice.Current"/></term><description>Value: ReservationIdentification4</description></item>
///   <item><term><see cref="CurrentOrDefaultReservation4Choice.Default"/></term><description>Value: ReservationIdentification4</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below — both variants wrap
/// the same nested type (ReservationIdentification4), so both use the same injected validator.
///
/// Dependency injection: each variant's nested <c>Value</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class CurrentOrDefaultReservation4Choice_Validator : AbstractValidator<CurrentOrDefaultReservation4Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for each variant's nested <c>Value</c> — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="reservationIdentificationValidator">
    /// Validator for both <see cref="CurrentOrDefaultReservation4Choice.Current"/>'s and
    /// <see cref="CurrentOrDefaultReservation4Choice.Default"/>'s <c>Value</c>
    /// (ReservationIdentification4).
    /// </param>
    public CurrentOrDefaultReservation4Choice_Validator(
        IValidator<ReservationIdentification4> reservationIdentificationValidator
    )
    {
        var currentVariantValidator = new InlineValidator<Choices.CurrentOrDefaultReservation4Choice.Current>();
        currentVariantValidator.RuleFor(x => x.Value).SetValidator(reservationIdentificationValidator);

        var defaultVariantValidator = new InlineValidator<Choices.CurrentOrDefaultReservation4Choice.Default>();
        defaultVariantValidator.RuleFor(x => x.Value).SetValidator(reservationIdentificationValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(currentVariantValidator);
                v.Add(defaultVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: both variants' <c>Value</c> are
    /// validated by the default validator (<see cref="ReservationIdentification4Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public CurrentOrDefaultReservation4Choice_Validator()
        : this(new ReservationIdentification4Validator()) { }
}
