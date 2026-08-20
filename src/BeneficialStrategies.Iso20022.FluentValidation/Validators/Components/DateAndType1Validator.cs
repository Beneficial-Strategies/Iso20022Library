// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DateAndType1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _wbqsoDHxEe6BxvG014AZzQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the date and type associated with the referred document.
/// <list type="table">
///   <item><term>Date</term><description>ISODate — required (1..1)</description></item>
///   <item><term>Type</term><description>DateType2Choice_ — required (1..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Type</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class DateAndType1Validator : AbstractValidator<DateAndType1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Type</c> building block — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="typeValidator">
    /// Validator for the required <c>Type</c> building block (DateType2Choice_, 1..1).
    /// </param>
    public DateAndType1Validator(IValidator<DateType2Choice_> typeValidator)
    {
        // Date: required (1..1) and already `required` C# property — format enforced by struct
        // constructor.

        RuleFor(x => x.Type).SetValidator(typeValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Type</c> building block is
    /// validated by its own default validator (<see cref="DateType2Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public DateAndType1Validator()
        : this(new DateType2Choice_Validator()) { }
}
