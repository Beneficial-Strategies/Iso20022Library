// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information related to the post trade of derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HtiKsDjlEfGFr5m_hAI8sw")]
[Description(@"Information related to the post trade of derivatives.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTradeDerivativeCode>))]
public readonly struct ExternalPostTradeDerivativeCode : IIsoExternalCode, IEquatable<ExternalPostTradeDerivativeCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTradeDerivativeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTradeDerivativeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTradeDerivativeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTradeDerivativeCode"/>.</summary>
    public static implicit operator ExternalPostTradeDerivativeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTradeDerivativeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTradeDerivativeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTradeDerivativeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeDerivativeCode a, ExternalPostTradeDerivativeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeDerivativeCode a, ExternalPostTradeDerivativeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeDerivativeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeDerivativeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTradeDerivativeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTradeDerivativeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Flag for transactions in ETCs, ETNs, SFPs and emission allowances, which benefit from a deferral.</summary>
    [IsoId("_HtiKsTjlEfGFr5m_hAI8sw")]
    [Description(@"Flag for transactions in ETCs, ETNs, SFPs and emission allowances, which benefit from a deferral.")]
    public static readonly ExternalPostTradeDerivativeCode Deferral = new("DEFF");

    /// <summary>Flag for transactions executed under the deferral for instruments for which there is not a liquid market.</summary>
    [IsoId("_HtiKtzjlEfGFr5m_hAI8sw")]
    [Description(@"Flag for transactions executed under the deferral for instruments for which there is not a liquid market.")]
    public static readonly ExternalPostTradeDerivativeCode IlliquidInstrumentTransaction = new("ILQD");

    /// <summary>Flag for transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.</summary>
    [IsoId("_HtiKvDjlEfGFr5m_hAI8sw")]
    [Description(@"Flag for transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.")]
    public static readonly ExternalPostTradeDerivativeCode PostTradeLISTransaction = new("LRGS");

    /// <summary>Flag for transactions executed under the post-trade size specific to the instrument deferral.</summary>
    [IsoId("_HtiKuzjlEfGFr5m_hAI8sw")]
    [Description(@"Flag for transactions executed under the post-trade size specific to the instrument deferral.")]
    public static readonly ExternalPostTradeDerivativeCode PostTradeSSTITransaction = new("SIZE");
}
