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
/// Versioned restriction of <see cref="ExternalBenchmarkTypeCode"/>. Length facet from MCP:
/// minLength=1, maxLength=4.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_uz0jkO14EfCkhZmdO7PIeg")]
[Description(@"Specifies the type of the benchmark, as defined in an external Benchmark Type code set. External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalBenchmarkType1Code>))]
public readonly struct ExternalBenchmarkType1Code : IIsoExternalCode, IEquatable<ExternalBenchmarkType1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalBenchmarkType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalBenchmarkType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalBenchmarkType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalBenchmarkType1Code"/>.</summary>
    public static implicit operator ExternalBenchmarkType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalBenchmarkType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalBenchmarkType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalBenchmarkType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalBenchmarkType1Code a, ExternalBenchmarkType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalBenchmarkType1Code a, ExternalBenchmarkType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalBenchmarkType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalBenchmarkType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalBenchmarkType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalBenchmarkType1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Commodity Benchmark subject to Annex II in the local Regulation.</summary>
    [IsoId("_FG3IofIrEfCUf7Ixom1D-A")]
    [Description(@"Commodity Benchmark subject to Annex II in the local Regulation.")]
    public static readonly ExternalBenchmarkType1Code CommodityBenchmarkAnnexII = new("CAII");

    /// <summary>European Union Climate Transition Benchmark (EU-CTB).</summary>
    [IsoId("_FG3vsfIrEfCUf7Ixom1D-A")]
    [Description(@"European Union Climate Transition Benchmark (EU-CTB).")]
    public static readonly ExternalBenchmarkType1Code EUClimateTransitionBenchmark = new("ECTB");

    /// <summary>European Union Paris-Aligned Benchmark (EU-PAB).</summary>
    [IsoId("_FG3Io_IrEfCUf7Ixom1D-A")]
    [Description(@"European Union Paris-Aligned Benchmark (EU-PAB).")]
    public static readonly ExternalBenchmarkType1Code EUParisAlignedBenchmark = new("EPAB");

    /// <summary>Other type of benchmark.</summary>
    [IsoId("_FG3vs_IrEfCUf7Ixom1D-A")]
    [Description(@"Other type of benchmark.")]
    public static readonly ExternalBenchmarkType1Code Other = new("OTHR");
}
