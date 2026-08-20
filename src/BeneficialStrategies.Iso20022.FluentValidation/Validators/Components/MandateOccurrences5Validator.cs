// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateOccurrences5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _VlU0kWZVEeuQ__SOdbf47A
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Provides further details related to the duration of the mandate and the occurrence of the
/// underlying transactions.
/// <list type="table">
///   <item><term>SequenceType</term><description>SequenceType2Code — required (1..1)</description></item>
///   <item><term>Frequency</term><description>Frequency36Choice_ — optional (0..1)</description></item>
///   <item><term>Duration</term><description>DatePeriod3 — optional (0..1)</description></item>
///   <item><term>FirstCollectionDate</term><description>ISODate — optional (0..1)</description></item>
///   <item><term>FinalCollectionDate</term><description>ISODate — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Frequency</c> and <c>Duration</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class MandateOccurrences5Validator : AbstractValidator<MandateOccurrences5>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>Frequency</c> and <c>Duration</c> building blocks — e.g. resolved
    /// from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="frequencyValidator">
    /// Validator for the optional <c>Frequency</c> building block (Frequency36Choice_, 0..1) —
    /// only invoked when present.
    /// </param>
    /// <param name="durationValidator">
    /// Validator for the optional <c>Duration</c> building block (DatePeriod3, 0..1) — only
    /// invoked when present.
    /// </param>
    public MandateOccurrences5Validator(
        IValidator<Frequency36Choice_> frequencyValidator,
        IValidator<DatePeriod3> durationValidator
    )
    {
        // SequenceType: required (1..1) and already `required` C# property — closed codeset
        // enum, no rule needed.
        // FirstCollectionDate, FinalCollectionDate: optional scalars, format enforced by struct
        // constructors — no rule needed.

        When(
            x => x.Frequency is not null,
            () => RuleFor(x => x.Frequency).SetValidator(frequencyValidator!)
        );

        When(
            x => x.Duration is not null,
            () => RuleFor(x => x.Duration).SetValidator(durationValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Frequency</c> and
    /// <c>Duration</c> are each validated by their own default validator
    /// (<see cref="Frequency36Choice_Validator"/>, <see cref="DatePeriod3Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateOccurrences5Validator()
        : this(new Frequency36Choice_Validator(), new DatePeriod3Validator()) { }
}
