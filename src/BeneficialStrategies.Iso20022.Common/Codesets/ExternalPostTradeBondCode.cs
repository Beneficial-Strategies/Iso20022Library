// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information related to the post trade of bonds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r08qNJOQEfCyoZKf5lUkBQ")]
[Description(@"Information related to the post trade of bonds.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTradeBondCode>))]
public readonly struct ExternalPostTradeBondCode : IIsoExternalCode, IEquatable<ExternalPostTradeBondCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTradeBondCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTradeBondCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTradeBondCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTradeBondCode"/>.</summary>
    public static implicit operator ExternalPostTradeBondCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTradeBondCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTradeBondCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTradeBondCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeBondCode a, ExternalPostTradeBondCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeBondCode a, ExternalPostTradeBondCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeBondCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeBondCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTradeBondCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTradeBondCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Flag for the publication of four-week aggregated transactions applicable to bonds.</summary>
    [IsoId("_r08qRpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for the publication of four-week aggregated transactions applicable to bonds.")]
    public static readonly ExternalPostTradeBondCode FourWeeksAggregation = new("AGFW");

    /// <summary>Flag when a previously published transaction is amended.</summary>
    [IsoId("_r08qQ5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag when a previously published transaction is amended.")]
    public static readonly ExternalPostTradeBondCode Amendment = new("AMND");

    /// <summary>Flag for transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.</summary>
    [IsoId("_r08qPJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.")]
    public static readonly ExternalPostTradeBondCode BenchmarkTransaction = new("BENC");

    /// <summary>Flag when a previously published transaction is cancelled.</summary>
    [IsoId("_r08qP5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag when a previously published transaction is cancelled.")]
    public static readonly ExternalPostTradeBondCode Cancellation = new("CANC");

    /// <summary>Full details flag G for Individual transactions in sovereign bonds which have previously benefited from aggregated publication.</summary>
    [IsoId("_r08qPpOQEfCyoZKf5lUkBQ")]
    [Description(@"Full details flag G for Individual transactions in sovereign bonds which have previously benefited from aggregated publication.")]
    public static readonly ExternalPostTradeBondCode FullDetailsWithPreviouslyAggregated = new("FULG");

    /// <summary>Full details flag O for transactions in a sovereign bond which has previously benefitted from the omission of the publication of the volume.</summary>
    [IsoId("_r08qPZOQEfCyoZKf5lUkBQ")]
    [Description(@"Full details flag O for transactions in a sovereign bond which has previously benefitted from the omission of the publication of the volume.")]
    public static readonly ExternalPostTradeBondCode FullDetailsWithPreviouslyOmitted = new("FULO");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is not a liquid market.</summary>
    [IsoId("_r08qOJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is not a liquid market.")]
    public static readonly ExternalPostTradeBondCode LargeIlliquid = new("LIF4");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is a liquid market.</summary>
    [IsoId("_r08qQJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is a liquid market.")]
    public static readonly ExternalPostTradeBondCode LargeLiquid = new("LLF3");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is not a liquid market.</summary>
    [IsoId("_r08qOpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is not a liquid market.")]
    public static readonly ExternalPostTradeBondCode MediumIlliquid = new("MIF2");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is a liquid market.</summary>
    [IsoId("_r08qQZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is a liquid market.")]
    public static readonly ExternalPostTradeBondCode MediumLiquid = new("MLF1");

    /// <summary>Flag for matched principal transactions.</summary>
    [IsoId("_r08qRJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for matched principal transactions.")]
    public static readonly ExternalPostTradeBondCode MatchedPrincipalTransaction = new("MTCH");

    /// <summary>Flag for transactions which are negotiated privately but reported under the rules of a trading venue.</summary>
    [IsoId("_r08qRZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions which are negotiated privately but reported under the rules of a trading venue.")]
    public static readonly ExternalPostTradeBondCode NegotiatedTransaction = new("NEGO");

    /// <summary>Flag for non-price forming transactions.</summary>
    [IsoId("_r08qQpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for non-price forming transactions.")]
    public static readonly ExternalPostTradeBondCode NonPriceFormingTransaction = new("NPFT");

    /// <summary>Flag for transactions in a sovereign bond which benefits from the omission of the publication of the volume.</summary>
    [IsoId("_r08qNpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in a sovereign bond which benefits from the omission of the publication of the volume.")]
    public static readonly ExternalPostTradeBondCode VolumeOmission = new("OMIS");

    /// <summary>Flag for transactions in five or more different financial instruments where those transactions are traded at the same time by the same client. It is used against a single lot price and that is not a ‘package transaction'.</summary>
    [IsoId("_r08qNZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.

It is used against a single lot price and that is not a ‘package transaction'.")]
    public static readonly ExternalPostTradeBondCode PortfolioTransaction = new("PORT");

    /// <summary>Flag for package transactions, which are not exchange for physicals.</summary>
    [IsoId("_r08qOZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for package transactions, which are not exchange for physicals.")]
    public static readonly ExternalPostTradeBondCode PackageTransaction = new("TPAC");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is not a liquid market.</summary>
    [IsoId("_r08qO5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is not a liquid market.")]
    public static readonly ExternalPostTradeBondCode VeryLargeIlliquid = new("VIF5");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is a liquid market</summary>
    [IsoId("_r08qR5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is a liquid market")]
    public static readonly ExternalPostTradeBondCode VeryLargeLiquid = new("VLF5");

    /// <summary>Flag for a transaction with exchange for physicals.</summary>
    [IsoId("_r08qN5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for a transaction with exchange for physicals.")]
    public static readonly ExternalPostTradeBondCode ExchangeForPhysicalsTransaction = new("XFPH");
}
