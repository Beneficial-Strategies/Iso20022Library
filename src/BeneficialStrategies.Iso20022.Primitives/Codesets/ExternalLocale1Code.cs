// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify the locale. Reference the IATA city codes for values.
/// </summary>
/// <remarks>
/// Note IATA (International Air Transport Association) maintains the codes at www.iata.org.
/// Versioned restriction of <see cref="ExternalLocaleCode"/>. Length facet from MCP: minLength=1,
/// maxLength=4. No code values are currently published for this code set in the MCP snapshot;
/// kept as a permissive open struct per CLAUDE.md's external-standard-exception guidance.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_vmyHQIMtEeevJdRXYDPjdQ")]
[Description(@"Code to identify the locale. Reference the IATA city codes for values.|Note IATA (International Air Transport Association) maintains the codes at www.iata.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalLocale1Code>))]
public readonly struct ExternalLocale1Code : IIsoExternalCode, IEquatable<ExternalLocale1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalLocale1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalLocale1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalLocale1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalLocale1Code"/>.</summary>
    public static implicit operator ExternalLocale1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalLocale1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalLocale1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalLocale1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalLocale1Code a, ExternalLocale1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalLocale1Code a, ExternalLocale1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalLocale1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalLocale1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalLocale1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalLocale1Code b) => a != b.Value;
}
