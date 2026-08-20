// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DateAndPlaceOfBirth1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _jU8IEa9UEeeJJK1oRb-jTw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Date and place of birth of a person.
/// <list type="table">
///   <item><term>BirthDate</term><description>ISODate — required (1..1)</description></item>
///   <item><term>ProvinceOfBirth</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>CityOfBirth</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>CountryOfBirth</term><description>CountryCode — required (1..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>CountryOfBirth</c> — an ISO 3166 <see cref="CountryCode"/> — is
/// checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> (via
/// <see cref="CountryCodeValidator"/>) rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class DateAndPlaceOfBirth1Validator : AbstractValidator<DateAndPlaceOfBirth1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>CountryOfBirth</c> — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="countryOfBirthValidator">
    /// Validator for the required <c>CountryOfBirth</c> (CountryCode, 1..1).
    /// </param>
    public DateAndPlaceOfBirth1Validator(IValidator<CountryCode> countryOfBirthValidator)
    {
        // BirthDate, CityOfBirth: required (1..1) and already `required` C# properties —
        // format/length enforced by struct constructors.
        // ProvinceOfBirth: Max35Text, optional — length [1..35] enforced by struct constructor.

        RuleFor(x => x.CountryOfBirth).SetValidator(countryOfBirthValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>CountryOfBirth</c> is validated
    /// by its own default validator (<see cref="CountryCodeValidator"/>). Convenience constructor
    /// for callers not using a DI container.
    /// </summary>
    public DateAndPlaceOfBirth1Validator()
        : this(new CountryCodeValidator()) { }
}
