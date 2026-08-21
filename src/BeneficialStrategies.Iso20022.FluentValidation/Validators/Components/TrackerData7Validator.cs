// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TrackerData7"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1YwfgTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Specifies the detailed information as provided by a payment tracking system.
/// <list type="table">
///   <item><term>ConfirmedAmount</term><description>ActiveCurrencyAndAmount — required (1..1), Amounts-namespace exemption</description></item>
///   <item><term>ConfirmedDate</term><description>DateAndDateTime2Choice_ — required (1..1)</description></item>
///   <item><term>TrackerRecord</term><description>TrackerRecord5 collection — required, min 1 (1..n)</description></item>
/// </list>
///
/// Known model defect: <c>TrackerRecord</c> is <c>ValueList&lt;T&gt; = []</c>, which allows an
/// empty collection at the C# level even though the spec requires Min=1..&#8734;. Enforced here via
/// an explicit <c>NotEmpty</c> rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>ConfirmedDate</c> and <c>TrackerRecord</c> are each validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below. (Upgraded 2026-08-21 from an earlier abbreviated version that only
/// enforced the multiplicity gap above — <see cref="TrackerRecord5Validator"/> did not exist yet
/// at that time.)
/// </remarks>
public class TrackerData7Validator : AbstractValidator<TrackerData7>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public TrackerData7Validator(
        IValidator<DateAndDateTime2Choice_> confirmedDateValidator,
        IValidator<TrackerRecord5> trackerRecordValidator
    )
    {
        RuleFor(x => x.ConfirmedDate).SetValidator(confirmedDateValidator!);

        RuleFor(x => x.TrackerRecord)
            .NotEmpty()
            .WithMessage("TrackerData7.TrackerRecord must contain at least one element (1..∞).");
        RuleForEach(x => x.TrackerRecord).SetValidator(trackerRecordValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TrackerData7Validator()
        : this(new DateAndDateTime2Choice_Validator(), new TrackerRecord5Validator()) { }
}
