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
/// Length facet from MCP: minLength=1, maxLength=4.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_n9TXsO14EfCkhZmdO7PIeg")]
[Description(@"Specifies the significance of the benchmark, as defined in an external Benchmark Significance code set. External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalBenchmarkSignificanceCode>))]
public readonly struct ExternalBenchmarkSignificanceCode : IIsoExternalCode, IEquatable<ExternalBenchmarkSignificanceCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalBenchmarkSignificanceCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalBenchmarkSignificanceCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalBenchmarkSignificanceCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalBenchmarkSignificanceCode"/>.</summary>
    public static implicit operator ExternalBenchmarkSignificanceCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalBenchmarkSignificanceCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalBenchmarkSignificanceCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalBenchmarkSignificanceCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalBenchmarkSignificanceCode a, ExternalBenchmarkSignificanceCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalBenchmarkSignificanceCode a, ExternalBenchmarkSignificanceCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalBenchmarkSignificanceCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalBenchmarkSignificanceCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalBenchmarkSignificanceCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalBenchmarkSignificanceCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Benchmark is critical under Art. 20(1).</summary>
    [IsoId("_c2DcIPXsEfCQzYdew2M4XQ")]
    [Description(@"Benchmark is critical under Art. 20(1).")]
    public static readonly ExternalBenchmarkSignificanceCode CriticalBenchmarkUnderArt201 = new("C201");

    /// <summary>Benchmark is neither significant nor critical.</summary>
    [IsoId("_n9TXsu14EfCkhZmdO7PIeg")]
    [Description(@"Benchmark is neither significant nor critical.")]
    public static readonly ExternalBenchmarkSignificanceCode NonSignificantAndNonCritical = new("NSNC");

    /// <summary>Benchmark is significant under Art. 24(2) as benchmark is above the threshold referred in the local Regulation.</summary>
    [IsoId("_n9TXt-14EfCkhZmdO7PIeg")]
    [Description(@"Benchmark is significant under Art. 24(2) as benchmark is above the threshold referred in the local Regulation.")]
    public static readonly ExternalBenchmarkSignificanceCode SignificantBenchmarkUnderArt242 = new("S242");

    /// <summary>Benchmark has been designated as significant by the national Authority under Art. 24 in accordance with the procedure laid down in paragraphs 3, 4 and 5 of the local Regulation.</summary>
    [IsoId("_n9TXtO14EfCkhZmdO7PIeg")]
    [Description(@"Benchmark has been designated as significant by the national Authority under Art. 24 in accordance with the procedure laid down in paragraphs 3, 4 and 5 of the local Regulation.")]
    public static readonly ExternalBenchmarkSignificanceCode SignificantBenchmarkUnderArt243 = new("S243");

    /// <summary>Benchmark has been designated as significant by the supranational Authority under Art. 24 in accordance with the procedure laid down in paragraph 6 of the local Regulation.</summary>
    [IsoId("_n9TXte14EfCkhZmdO7PIeg")]
    [Description(@"Benchmark has been designated as significant by the supranational Authority under Art. 24 in accordance with the procedure laid down in paragraph 6 of the local Regulation.")]
    public static readonly ExternalBenchmarkSignificanceCode SignificantBenchmarkUnderArt246 = new("S246");

    /// <summary>Following request submitted by the administration to be designated as significant, the benchmark has been designated as significant by the national Authority under Art. 24 in accordance with the procedure laid down in paragraph 7 of the local Regulation.</summary>
    [IsoId("_n9TXse14EfCkhZmdO7PIeg")]
    [Description(@"Following request submitted by the administration to be designated as significant, the benchmark has been designated as significant by the national Authority under Art. 24 in accordance with the procedure laid down in paragraph 7 of the local Regulation.")]
    public static readonly ExternalBenchmarkSignificanceCode SignificantBenchmarkUnderArt247 = new("S247");
}
