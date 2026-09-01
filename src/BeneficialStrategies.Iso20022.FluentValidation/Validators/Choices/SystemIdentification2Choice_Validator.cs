// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="SystemIdentification2Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _8BZ3QaMgEeCJ6YNENx4h-w_-1347709917
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Information used to identify a cash clearing system.
/// <list type="table">
///   <item><term><see cref="Choices.SystemIdentification2Choice.MarketInfrastructureIdentification"/></term><description>Clearing service selected for a transaction — carries no properties at all in this generation of the model (unlike other identical-sounding scheme-name choices elsewhere in the library), so there is nothing to validate</description></item>
///   <item><term><see cref="Choices.SystemIdentification2Choice.Country"/></term><description>Country in which the system is located — Value: CountryCode (external code set — see <see cref="CountryCodeValidator"/>)</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below. Only the
/// <c>Country</c> variant gets an <see cref="InlineValidator{T}"/> — the
/// <c>MarketInfrastructureIdentification</c> variant has no properties to check, so no validator
/// is registered for it; <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// leaves an unregistered variant type as always-valid by design (see
/// <see cref="Party50Choice_Validator"/>'s own remarks).
///
/// Dependency injection: the <c>Country</c> variant's <c>Value</c> is checked against an injected
/// <see cref="IExternalCodeRegistry{TCode}"/> (via <see cref="CountryCodeValidator"/>) rather than
/// a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class SystemIdentification2Choice_Validator : AbstractValidator<SystemIdentification2Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Country</c> variant's <c>Value</c> — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="countryValueValidator">
    /// Validator for <see cref="Choices.SystemIdentification2Choice.Country"/>'s <c>Value</c>
    /// (CountryCode).
    /// </param>
    public SystemIdentification2Choice_Validator(IValidator<CountryCode> countryValueValidator)
    {
        var countryVariantValidator = new InlineValidator<Choices.SystemIdentification2Choice.Country>();
        countryVariantValidator.RuleFor(x => x.Value).SetValidator(countryValueValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(countryVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Country</c> variant's
    /// <c>Value</c> is validated by its own default validator (<see cref="CountryCodeValidator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public SystemIdentification2Choice_Validator()
        : this(new CountryCodeValidator()) { }
}
