// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Globalization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Shared parsing/formatting for the optional W3C XSD timezone suffix (<c>Z</c>,
/// <c>+HH:MM</c>, <c>-HH:MM</c>) permitted on <c>xs:gYear</c>, <c>xs:gYearMonth</c>,
/// <c>xs:gMonth</c>, <c>xs:gMonthDay</c>, and <c>xs:gDay</c>.
/// </summary>
internal static class XsdTimezone
{
    /// <summary>
    /// Splits a trailing timezone suffix off <paramref name="text"/>, if present.
    /// </summary>
    /// <returns>
    /// The remaining (non-timezone) text and the parsed offset — <see langword="null"/> when no
    /// timezone suffix was present, <see cref="TimeSpan.Zero"/> for <c>Z</c>, or the parsed
    /// <c>+HH:MM</c>/<c>-HH:MM</c> offset.
    /// </returns>
    /// <exception cref="FormatException">The offset falls outside -14:00..+14:00.</exception>
    public static (string Core, TimeSpan? Offset) SplitTrailingTimezone(string text)
    {
        if (text.EndsWith('Z'))
            return (text[..^1], TimeSpan.Zero);

        // A trailing "+HH:MM" or "-HH:MM" is exactly 6 characters. Matching from the end (rather
        // than a leading regex) avoids confusing a timezone sign with the leading minus on a
        // negative xs:gYear (e.g. "-0043-05:00" is year -0043, timezone -05:00).
        if (text.Length >= 6)
        {
            var tail = text[^6..];
            if ((tail[0] == '+' || tail[0] == '-')
                && char.IsDigit(tail[1]) && char.IsDigit(tail[2])
                && tail[3] == ':'
                && char.IsDigit(tail[4]) && char.IsDigit(tail[5]))
            {
                var hours = int.Parse(tail.AsSpan(1, 2), CultureInfo.InvariantCulture);
                var minutes = int.Parse(tail.AsSpan(4, 2), CultureInfo.InvariantCulture);
                var magnitude = new TimeSpan(hours, minutes, 0);
                if (magnitude > TimeSpan.FromHours(14))
                    throw new FormatException($"Timezone offset '{tail}' is outside the permitted range of -14:00 to +14:00.");
                var offset = tail[0] == '-' ? -magnitude : magnitude;
                return (text[..^6], offset);
            }
        }
        return (text, null);
    }

    /// <summary>Formats a timezone offset per the W3C XSD canonical lexical form.</summary>
    public static string Format(TimeSpan? offset)
    {
        if (offset is null)
            return string.Empty;
        if (offset == TimeSpan.Zero)
            return "Z";
        var magnitude = offset.Value.Duration();
        return $"{(offset < TimeSpan.Zero ? '-' : '+')}{magnitude.Hours:D2}:{magnitude.Minutes:D2}";
    }
}
