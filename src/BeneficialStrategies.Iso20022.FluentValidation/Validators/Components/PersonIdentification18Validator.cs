// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PersonIdentification18"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _-9oltTFLEe651u5xu3f5iw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Unique and unambiguous way to identify a person.
/// <list type="table">
///   <item><term>DateAndPlaceOfBirth</term><description>DateAndPlaceOfBirth1 — optional (0..1)</description></item>
///   <item><term>Other</term><description>GenericPersonIdentification2 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>DateAndPlaceOfBirth</c> building block and the <c>Other</c>
/// collection are each validated by an injected <see cref="IValidator{T}"/> rather than a
/// hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class PersonIdentification18Validator : AbstractValidator<PersonIdentification18>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>DateAndPlaceOfBirth</c> building block and the <c>Other</c>
    /// collection's item type — e.g. resolved from a DI container — instead of this type
    /// constructing its own.
    /// </summary>
    /// <param name="dateAndPlaceOfBirthValidator">
    /// Validator for the optional <c>DateAndPlaceOfBirth</c> building block
    /// (DateAndPlaceOfBirth1, 0..1) — only invoked when present.
    /// </param>
    /// <param name="otherValidator">
    /// Validator for each item of the <c>Other</c> collection (GenericPersonIdentification2, 0..∞).
    /// </param>
    public PersonIdentification18Validator(
        IValidator<DateAndPlaceOfBirth1> dateAndPlaceOfBirthValidator,
        IValidator<GenericPersonIdentification2> otherValidator
    )
    {
        When(
            x => x.DateAndPlaceOfBirth is not null,
            () =>
                RuleFor(x => x.DateAndPlaceOfBirth).SetValidator(dateAndPlaceOfBirthValidator!)
        );

        RuleForEach(x => x.Other).SetValidator(otherValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>DateAndPlaceOfBirth</c>
    /// building block and the <c>Other</c> collection are each validated by their own default
    /// validator (<see cref="DateAndPlaceOfBirth1Validator"/>,
    /// <see cref="GenericPersonIdentification2Validator"/>). Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PersonIdentification18Validator()
        : this(new DateAndPlaceOfBirth1Validator(), new GenericPersonIdentification2Validator()) { }
}
