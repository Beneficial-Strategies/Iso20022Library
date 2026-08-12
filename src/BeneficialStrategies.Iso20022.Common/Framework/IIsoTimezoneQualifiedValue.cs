// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Marks an <see cref="IIsoSimpleValue{T}"/> struct whose W3C XSD lexical representation carries
/// an optional timezone suffix (<c>Z</c>, <c>+HH:MM</c>, <c>-HH:MM</c>) alongside <c>Value</c> —
/// <c>xs:gYear</c>, <c>xs:gYearMonth</c>, <c>xs:gMonth</c>, <c>xs:gMonthDay</c>, and
/// <c>xs:gDay</c>.
/// </summary>
/// <remarks>
/// Extends <see cref="IIsoCompositeSimpleValue"/> — see that interface for why the serializer
/// treats these specially. Implementing this interface additionally exposes the parsed timezone
/// to callers.
/// </remarks>
public interface IIsoTimezoneQualifiedValue : IIsoCompositeSimpleValue
{
    /// <summary>
    /// The optional timezone offset from the lexical representation: <see langword="null"/> when
    /// no timezone was present (a locally-qualified value), <see cref="TimeSpan.Zero"/> for the
    /// canonical UTC form (<c>Z</c>), or an offset in the range -14:00 to +14:00.
    /// </summary>
    TimeSpan? TimezoneOffset { get; }
}
