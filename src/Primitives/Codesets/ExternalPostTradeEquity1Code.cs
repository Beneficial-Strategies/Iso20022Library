// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information related to the post trade of equities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r09RRZOQEfCyoZKf5lUkBQ")]
[Description(@"Information related to the post trade of equities.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTradeEquity1Code>))]
public readonly struct ExternalPostTradeEquity1Code : IIsoExternalCode, IEquatable<ExternalPostTradeEquity1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTradeEquity1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTradeEquity1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTradeEquity1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTradeEquity1Code"/>.</summary>
    public static implicit operator ExternalPostTradeEquity1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTradeEquity1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTradeEquity1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTradeEquity1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeEquity1Code a, ExternalPostTradeEquity1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeEquity1Code a, ExternalPostTradeEquity1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeEquity1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeEquity1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTradeEquity1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTradeEquity1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here. Descriptions borrowed from the
    // sibling ExternalPostTradeEquityCode codeset (this codeset's own get_code_set_details
    // response returns blank definitions for every code — same code names, same registry entries).

    /// <summary>Flag for transactions executed as a result of an investment firm engaging in algorithmic trading</summary>
    [IsoId("_r09RTpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions executed as a result of an investment firm engaging in  algorithmic trading")]
    public static readonly ExternalPostTradeEquity1Code AlgorithmicTransaction = new("ALGO");

    /// <summary>Flag when a previously published transaction is amended.</summary>
    [IsoId("_r09RUJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag when a previously published transaction is amended.")]
    public static readonly ExternalPostTradeEquity1Code Amendment = new("AMND");

    /// <summary>Flag for transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.</summary>
    [IsoId("_r09RUZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions executed in reference to a price that is calculated over
multiple time instances according to a given benchmark.")]
    public static readonly ExternalPostTradeEquity1Code BenchmarkTransaction = new("BENC");

    /// <summary>Flag when a previously published transaction is cancelled.</summary>
    [IsoId("_r09RSZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag when a previously published transaction is cancelled.")]
    public static readonly ExternalPostTradeEquity1Code Cancellation = new("CANC");

    /// <summary>Flag for transactions that are contingent on the purchase, sale, creation or redemption of a derivative contract or other financial instrument where all the components of the trade are meant to be executed as a single lot.</summary>
    [IsoId("_r09RV5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions that are contingent on the purchase, sale, creation or redemption of a derivative contract or other financial instrument where all the components of the trade are meant to be executed as a single lot.")]
    public static readonly ExternalPostTradeEquity1Code ContingentTransaction = new("CONT");

    /// <summary>Flag for transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.</summary>
    [IsoId("_r09RVZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.")]
    public static readonly ExternalPostTradeEquity1Code PostTradeLISTransaction = new("LRGS");

    /// <summary>Flag for transactions made within the current volume weighted spread reflected on the order book or the quotes of the market makers of the trading venue operating that system.</summary>
    [IsoId("_r09RR5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions made within the current volume weighted spread reflected on the order book or the quotes of the market makers of the trading venue operating that system.")]
    public static readonly ExternalPostTradeEquity1Code NegotiatedTransactionInLiquidFinancialInstruments = new("NLIQ");

    /// <summary>Flag for non-price forming transactions</summary>
    [IsoId("_r09RTJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for non-price forming transactions")]
    public static readonly ExternalPostTradeEquity1Code NonPriceFormingTransaction = new("NPFT");

    /// <summary>Flag for transactions in an illiquid instrument traded at a system-set percentage of a reference price.</summary>
    [IsoId("_r09RS5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in an illiquid instrument traded at a system-set percentage of a reference price.")]
    public static readonly ExternalPostTradeEquity1Code NegotiatedTransactionInIlliquidFinancialInstruments = new("OILQ");

    /// <summary>Flag for transactions in five or more different financial instruments where those transactions are traded at the same time by the same client. It is used as a single lot price and that is not a ‘package transaction'.</summary>
    [IsoId("_r09RSJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.

It is used as a single lot price and that is not a ‘package transaction'.")]
    public static readonly ExternalPostTradeEquity1Code PortfolioTransaction = new("PORT");

    /// <summary>Flag for transactions executed subject to conditions other than the current market price of that financial instrument.</summary>
    [IsoId("_r09RU5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions executed subject to conditions other than the current market price of that financial instrument.")]
    public static readonly ExternalPostTradeEquity1Code NegotiatedTransactionSubjectToConditionsOtherThanTheCurrentMarketPrice = new("PRIC");

    /// <summary>Flag for transactions which are executed under systems.</summary>
    [IsoId("_r09RT5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions which are executed under systems.")]
    public static readonly ExternalPostTradeEquity1Code ReferencePriceTransaction = new("RFPT");

    /// <summary>Flag for transactions where dividends accrue to the non-entitled party due to ex- or cum-dividend timing.</summary>
    [IsoId("_r09RSpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions where dividends accrue to the non-entitled party due to ex- or cum-dividend timing.")]
    public static readonly ExternalPostTradeEquity1Code SpecialDividendTransaction = new("SDIV");
}
