// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the significance of the benchmark, as defined in an external Benchmark Significance code set. External code sets can be downloaded from www.iso20022.org.
/// </summary>
/// <remarks>
/// Versioned restriction of <see cref="ExternalBenchmarkSignificanceCode"/>. Length facet from
/// MCP: minLength=1, maxLength=4.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YLe9YO17EfCkhZmdO7PIeg")]
[Description(@"Specifies the significance of the benchmark, as defined in an external Benchmark Significance code set. External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalBenchmarkSignificance1Code>))]
public readonly struct ExternalBenchmarkSignificance1Code : IIsoExternalCode, IEquatable<ExternalBenchmarkSignificance1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalBenchmarkSignificance1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalBenchmarkSignificance1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalBenchmarkSignificance1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalBenchmarkSignificance1Code"/>.</summary>
    public static implicit operator ExternalBenchmarkSignificance1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalBenchmarkSignificance1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalBenchmarkSignificance1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalBenchmarkSignificance1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalBenchmarkSignificance1Code a, ExternalBenchmarkSignificance1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalBenchmarkSignificance1Code a, ExternalBenchmarkSignificance1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalBenchmarkSignificance1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalBenchmarkSignificance1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalBenchmarkSignificance1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalBenchmarkSignificance1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Benchmark is critical under Art. 20(1).</summary>
    [IsoId("_ytMHgfXsEfCQzYdew2M4XQ")]
    [Description(@"Benchmark is critical under Art. 20(1).")]
    public static readonly ExternalBenchmarkSignificance1Code CriticalBenchmarkUnderArt201 = new("C201");

    /// <summary>Benchmark is neither significant nor critical.</summary>
    [IsoId("_YNyDee17EfCkhZmdO7PIeg")]
    [Description(@"Benchmark is neither significant nor critical.")]
    public static readonly ExternalBenchmarkSignificance1Code NonSignificantAndNonCritical = new("NSNC");

    /// <summary>Benchmark is significant under Art. 24(2) as benchmark is above the threshold referred in the local Regulation.</summary>
    [IsoId("_YNyDce17EfCkhZmdO7PIeg")]
    [Description(@"Benchmark is significant under Art. 24(2) as benchmark is above the threshold referred in the local Regulation.")]
    public static readonly ExternalBenchmarkSignificance1Code SignificantBenchmarkUnderArt242 = new("S242");

    /// <summary>Benchmark has been designated as significant by the national Authority under Art. 24 in accordance with the procedure laid down in paragraphs 3, 4 and 5 of the local Regulation.</summary>
    [IsoId("_YNyDc-17EfCkhZmdO7PIeg")]
    [Description(@"Benchmark has been designated as significant by the national Authority under Art. 24 in accordance with the procedure laid down in paragraphs 3, 4 and 5 of the local Regulation.")]
    public static readonly ExternalBenchmarkSignificance1Code SignificantBenchmarkUnderArt243 = new("S243");

    /// <summary>Benchmark has been designated as significant by the supranational Authority under Art. 24 in accordance with the procedure laid down in paragraph 6 of the local Regulation.</summary>
    [IsoId("_YNyDde17EfCkhZmdO7PIeg")]
    [Description(@"Benchmark has been designated as significant by the supranational Authority under Art. 24 in accordance with the procedure laid down in paragraph 6 of the local Regulation.")]
    public static readonly ExternalBenchmarkSignificance1Code SignificantBenchmarkUnderArt246 = new("S246");

    /// <summary>Following request submitted by the administration to be designated as significant, the benchmark has been designated as significant by the national Authority under Art. 24 in accordance with the procedure laid down in paragraph 7 of the local Regulation.</summary>
    [IsoId("_YNyDd-17EfCkhZmdO7PIeg")]
    [Description(@"Following request submitted by the administration to be designated as significant, the benchmark has been designated as significant by the national Authority under Art. 24 in accordance with the procedure laid down in paragraph 7 of the local Regulation.")]
    public static readonly ExternalBenchmarkSignificance1Code SignificantBenchmarkUnderArt247 = new("S247");
}
