// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information related to the post trade of equities
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r09RVJOQEfCyoZKf5lUkBQ")]
[Description(@"Information related to the post trade of equities")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTradeEquityCode>))]
public readonly struct ExternalPostTradeEquityCode : IIsoExternalCode, IEquatable<ExternalPostTradeEquityCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTradeEquityCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTradeEquityCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTradeEquityCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTradeEquityCode"/>.</summary>
    public static implicit operator ExternalPostTradeEquityCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTradeEquityCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTradeEquityCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTradeEquityCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeEquityCode a, ExternalPostTradeEquityCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeEquityCode a, ExternalPostTradeEquityCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeEquityCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeEquityCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTradeEquityCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTradeEquityCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Flag for transactions executed as a result of an investment firm engaging in algorithmic trading</summary>
    [IsoId("_r09RWpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions executed as a result of an investment firm engaging in  algorithmic trading")]
    public static readonly ExternalPostTradeEquityCode AlgorithmicTransaction = new("ALGO");

    /// <summary>Flag when a previously published transaction is amended.</summary>
    [IsoId("_r094QJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag when a previously published transaction is amended.")]
    public static readonly ExternalPostTradeEquityCode Amendment = new("AMND");

    /// <summary>Flag for transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.</summary>
    [IsoId("_r09RWJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions executed in reference to a price that is calculated over
multiple time instances according to a given benchmark.")]
    public static readonly ExternalPostTradeEquityCode BenchmarkTransaction = new("BENC");

    /// <summary>Flag when a previously published transaction is cancelled.</summary>
    [IsoId("_r09RW5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag when a previously published transaction is cancelled.")]
    public static readonly ExternalPostTradeEquityCode Cancellation = new("CANC");

    /// <summary>Flag for transactions that are contingent on the purchase, sale, creation or redemption of a derivative contract or other financial instrument where all the components of the trade are meant to be executed as a single lot.</summary>
    [IsoId("_r09RV5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions that are contingent on the purchase, sale, creation or redemption of a derivative contract or other financial instrument where all the components of the trade are meant to be executed as a single lot.")]
    public static readonly ExternalPostTradeEquityCode ContingentTransaction = new("CONT");

    /// <summary>Flag for transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.</summary>
    [IsoId("_r09RVZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.")]
    public static readonly ExternalPostTradeEquityCode PostTradeLISTransaction = new("LRGS");

    /// <summary>Flag for transactions made within the current volume weighted spread reflected on the order book or the quotes of the market makers of the trading venue operating that system.</summary>
    [IsoId("_r094RJOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions made within the current volume weighted spread reflected on the order book or the quotes of the market makers of the trading venue operating that system.")]
    public static readonly ExternalPostTradeEquityCode NegotiatedTransactionInLiquidFinancialInstruments = new("NLIQ");

    /// <summary>Flag for non-price forming transactions</summary>
    [IsoId("_r094QZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for non-price forming transactions")]
    public static readonly ExternalPostTradeEquityCode NonPriceFormingTransaction = new("NPFT");

    /// <summary>Flag for transactions in an illiquid instrument traded at a system-set percentage of a reference price.</summary>
    [IsoId("_r09RVpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in an illiquid instrument traded at a system-set percentage of a reference price.")]
    public static readonly ExternalPostTradeEquityCode NegotiatedTransactionInIlliquidFinancialInstruments = new("OILQ");

    /// <summary>Flag for transactions in five or more different financial instruments where those transactions are traded at the same time by the same client. It is used as a single lot price and that is not a ‘package transaction'.</summary>
    [IsoId("_r09RXZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.

It is used as a single lot price and that is not a ‘package transaction'.")]
    public static readonly ExternalPostTradeEquityCode PortfolioTransaction = new("PORT");

    /// <summary>Flag for transactions executed subject to conditions other than the current market price of that financial instrument.</summary>
    [IsoId("_r094QpOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions executed subject to conditions other than the current market price of that financial instrument.")]
    public static readonly ExternalPostTradeEquityCode NegotiatedTransactionSubjectToConditionsOtherThanTheCurrentMarketPrice = new("PRIC");

    /// <summary>Flag for transactions which are executed under systems.</summary>
    [IsoId("_r09RWZOQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions which are executed under systems.")]
    public static readonly ExternalPostTradeEquityCode ReferencePriceTransaction = new("RFPT");

    /// <summary>Flag for transactions where dividends accrue to the non-entitled party due to ex- or cum-dividend timing.</summary>
    [IsoId("_r094Q5OQEfCyoZKf5lUkBQ")]
    [Description(@"Flag for transactions where dividends accrue to the non-entitled party due to ex- or cum-dividend timing.")]
    public static readonly ExternalPostTradeEquityCode SpecialDividendTransaction = new("SDIV");
}
