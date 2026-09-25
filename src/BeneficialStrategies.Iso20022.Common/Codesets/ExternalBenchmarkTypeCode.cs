// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the benchmark, as defined in an external Benchmark Type code set. External code sets can be downloaded from www.iso20022.org.
/// </summary>
/// <remarks>
/// Length facet from MCP: minLength=1, maxLength=4.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_n9TXtu14EfCkhZmdO7PIeg")]
[Description(@"Specifies the type of the benchmark, as defined in an external Benchmark Type code set. External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalBenchmarkTypeCode>))]
public readonly struct ExternalBenchmarkTypeCode : IIsoExternalCode, IEquatable<ExternalBenchmarkTypeCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalBenchmarkTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalBenchmarkTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalBenchmarkTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalBenchmarkTypeCode"/>.</summary>
    public static implicit operator ExternalBenchmarkTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalBenchmarkTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalBenchmarkTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalBenchmarkTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalBenchmarkTypeCode a, ExternalBenchmarkTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalBenchmarkTypeCode a, ExternalBenchmarkTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalBenchmarkTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalBenchmarkTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalBenchmarkTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalBenchmarkTypeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Commodity Benchmark subject to Annex II in the local Regulation.</summary>
    [IsoId("_n9TXt-14EfCkhZmdO7PIeg")]
    [Description(@"Commodity Benchmark subject to Annex II in the local Regulation.")]
    public static readonly ExternalBenchmarkTypeCode CommodityBenchmarkAnnexII = new("CAII");

    /// <summary>European Union Climate Transition Benchmark (EU-CTB).</summary>
    [IsoId("_n9TXue14EfCkhZmdO7PIeg")]
    [Description(@"European Union Climate Transition Benchmark (EU-CTB).")]
    public static readonly ExternalBenchmarkTypeCode EUClimateTransitionBenchmark = new("ECTB");

    /// <summary>European Union Paris-Aligned Benchmark (EU-PAB).</summary>
    [IsoId("_n9TXuu14EfCkhZmdO7PIeg")]
    [Description(@"European Union Paris-Aligned Benchmark (EU-PAB).")]
    public static readonly ExternalBenchmarkTypeCode EUParisAlignedBenchmark = new("EPAB");

    /// <summary>Other type of benchmark.</summary>
    [IsoId("_n9TXuO14EfCkhZmdO7PIeg")]
    [Description(@"Other type of benchmark.")]
    public static readonly ExternalBenchmarkTypeCode Other = new("OTHR");
}
