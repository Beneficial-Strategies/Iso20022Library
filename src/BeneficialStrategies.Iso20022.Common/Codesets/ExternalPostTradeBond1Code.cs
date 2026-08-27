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
[IsoId("_r08qIJOQEfCyoZKf5lUkBQ")]
[Description(@"Information related to the post trade of bonds.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTradeBond1Code>))]
public readonly struct ExternalPostTradeBond1Code : IIsoExternalCode, IEquatable<ExternalPostTradeBond1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTradeBond1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTradeBond1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTradeBond1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTradeBond1Code"/>.</summary>
    public static implicit operator ExternalPostTradeBond1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTradeBond1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTradeBond1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTradeBond1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeBond1Code a, ExternalPostTradeBond1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeBond1Code a, ExternalPostTradeBond1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeBond1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeBond1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTradeBond1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTradeBond1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here. Descriptions borrowed from the
    // sibling ExternalPostTradeBondCode codeset (this codeset's own get_code_set_details
    // response returns blank definitions for every code — same code names, same registry entries).

    /// <summary>Flag for the publication of four-week aggregated transactions applicable to bonds.</summary>
    [IsoId("_r08qLZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for the publication of four-week aggregated transactions applicable to bonds.")]
    public static readonly ExternalPostTradeBond1Code FourWeeksAggregation = new("AGFW");

    /// <summary>Flag when a previously published transaction is amended.</summary>
    [IsoId("_r08qJ5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag when a previously published transaction is amended.")]
    public static readonly ExternalPostTradeBond1Code Amendment = new("AMND");

    /// <summary>Flag for transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.</summary>
    [IsoId("_r08qKZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.")]
    public static readonly ExternalPostTradeBond1Code BenchmarkTransaction = new("BENC");

    /// <summary>Flag when a previously published transaction is cancelled.</summary>
    [IsoId("_r08qMZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag when a previously published transaction is cancelled.")]
    public static readonly ExternalPostTradeBond1Code Cancellation = new("CANC");

    /// <summary>Full details flag G for Individual transactions in sovereign bonds which have previously benefited from aggregated publication.</summary>
    [IsoId("_r08qLpOQEfCyoZKf5lUkBQ")]
    [Description(@"Full details flag G for Individual transactions in sovereign bonds which have previously benefited from aggregated publication.")]
    public static readonly ExternalPostTradeBond1Code FullDetailsWithPreviouslyAggregated = new("FULG");

    /// <summary>Full details flag O for transactions in a sovereign bond which has previously benefitted from the omission of the publication of the volume.</summary>
    [IsoId("_r08qL5OQEfCyoZKf5lUkBQ")]
    [Description(@"Full details flag O for transactions in a sovereign bond which has previously benefitted from the omission of the publication of the volume.")]
    public static readonly ExternalPostTradeBond1Code FullDetailsWithPreviouslyOmitted = new("FULO");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is not a liquid market.</summary>
    [IsoId("_r08qI5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is not a liquid market.")]
    public static readonly ExternalPostTradeBond1Code LargeIlliquid = new("LIF4");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is a liquid market.</summary>
    [IsoId("_r08qIZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is a liquid market.")]
    public static readonly ExternalPostTradeBond1Code LargeLiquid = new("LLF3");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is not a liquid market.</summary>
    [IsoId("_r08qMpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is not a liquid market.")]
    public static readonly ExternalPostTradeBond1Code MediumIlliquid = new("MIF2");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is a liquid market.</summary>
    [IsoId("_r08qJpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is a liquid market.")]
    public static readonly ExternalPostTradeBond1Code MediumLiquid = new("MLF1");

    /// <summary>Flag for matched principal transactions.</summary>
    [IsoId("_r08qKJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for matched principal transactions.")]
    public static readonly ExternalPostTradeBond1Code MatchedPrincipalTransaction = new("MTCH");

    /// <summary>Flag for transactions which are negotiated privately but reported under the rules of a trading venue.</summary>
    [IsoId("_r08qJJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions which are negotiated privately but reported under the rules of a trading venue.")]
    public static readonly ExternalPostTradeBond1Code NegotiatedTransaction = new("NEGO");

    /// <summary>Flag for non-price forming transactions.</summary>
    [IsoId("_r08qMJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for non-price forming transactions.")]
    public static readonly ExternalPostTradeBond1Code NonPriceFormingTransaction = new("NPFT");

    /// <summary>Flag for transactions in a sovereign bond which benefits from the omission of the publication of the volume.</summary>
    [IsoId("_r08qJZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in a sovereign bond which benefits from the omission of the publication of the volume.")]
    public static readonly ExternalPostTradeBond1Code VolumeOmission = new("OMIS");

    /// <summary>Flag for transactions in five or more different financial instruments where those transactions are traded at the same time by the same client. It is used against a single lot price and that is not a ‘package transaction'.</summary>
    [IsoId("_r08qIpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.

It is used against a single lot price and that is not a ‘package transaction'.")]
    public static readonly ExternalPostTradeBond1Code PortfolioTransaction = new("PORT");

    /// <summary>Flag for package transactions, which are not exchange for physicals.</summary>
    [IsoId("_r08qK5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for package transactions, which are not exchange for physicals.")]
    public static readonly ExternalPostTradeBond1Code PackageTransaction = new("TPAC");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is not a liquid market.</summary>
    [IsoId("_r08qM5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is not a liquid market.")]
    public static readonly ExternalPostTradeBond1Code VeryLargeIlliquid = new("VIF5");

    /// <summary>Flag for transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is a liquid market</summary>
    [IsoId("_r08qLJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is a liquid market")]
    public static readonly ExternalPostTradeBond1Code VeryLargeLiquid = new("VLF5");

    /// <summary>Flag for a transaction with exchange for physicals.</summary>
    [IsoId("_r08qKpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for a transaction with exchange for physicals.")]
    public static readonly ExternalPostTradeBond1Code ExchangeForPhysicalsTransaction = new("XFPH");
}
