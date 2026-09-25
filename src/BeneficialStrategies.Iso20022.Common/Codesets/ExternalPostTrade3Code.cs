// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information related to the post trade of equities
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org. Versioned restriction of <see cref="ExternalPostTradeCode"/> — an equities-specific subset of the base codeset's wire values; each member below carries its own IsoId distinct from the base codeset's IsoId for the same wire code, per CLAUDE.md's hybrid-pattern guidance. No length facet published by MCP for this codeset; Pattern kept at the conventional 1-4 character range observed across all published member codes.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_24slMGh_EfCsrrIilHxTfw")]
[Description(@"Information related to the post trade of equities")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTrade3Code>))]
public readonly struct ExternalPostTrade3Code : IIsoExternalCode, IEquatable<ExternalPostTrade3Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTrade3Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTrade3Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTrade3Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTrade3Code"/>.</summary>
    public static implicit operator ExternalPostTrade3Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTrade3Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTrade3Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTrade3Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTrade3Code a, ExternalPostTrade3Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTrade3Code a, ExternalPostTrade3Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTrade3Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTrade3Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTrade3Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTrade3Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Transactions executed as a result of an investment firm engaging in algorithmic trading</summary>
    [IsoId("_RXKoEWiAEfCsrrIilHxTfw")]
    [Description(@"Transactions executed as a result of an investment firm engaging in algorithmic trading")]
    public static readonly ExternalPostTrade3Code AlgorithmicTransactionFlag = new("ALGO");

    /// <summary>When a previously published transaction is amended.</summary>
    [IsoId("_SCsRUWiAEfCsrrIilHxTfw")]
    [Description(@"When a previously published transaction is amended.")]
    public static readonly ExternalPostTrade3Code AmendmentFlag = new("AMND");

    /// <summary>Transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.</summary>
    [IsoId("_HSTQ4WiAEfCsrrIilHxTfw")]
    [Description(@"Transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.")]
    public static readonly ExternalPostTrade3Code BenchmarkTransactionsFlag = new("BENC");

    /// <summary>When a previously published transaction is cancelled.</summary>
    [IsoId("_SOzasWiAEfCsrrIilHxTfw")]
    [Description(@"When a previously published transaction is cancelled.")]
    public static readonly ExternalPostTrade3Code CancellationFlag = new("CANC");

    /// <summary>Transactions that are contingent on the purchase, sale, creation or redemption of a derivative contract or other financial instrument where all the components of the trade are meant to be executed as a single lot.</summary>
    [IsoId("_KorW0WiAEfCsrrIilHxTfw")]
    [Description(@"Transactions that are contingent on the purchase, sale, creation or redemption of a derivative contract or other financial instrument where all the components of the trade are meant to be executed as a single lot.")]
    public static readonly ExternalPostTrade3Code ContingentTransactionsFlag = new("CONT");

    /// <summary>Transactions in ETCs, ETNs, SFPs and emission allowances, which benefit from a deferral.</summary>
    [IsoId("_FudfkWiAEfCsrrIilHxTfw")]
    [Description(@"Transactions in ETCs, ETNs, SFPs and emission allowances, which benefit from a deferral.")]
    public static readonly ExternalPostTrade3Code DeferralFlag = new("DEFF");

    /// <summary>Transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.</summary>
    [IsoId("_NddLkWiAEfCsrrIilHxTfw")]
    [Description(@"Transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.")]
    public static readonly ExternalPostTrade3Code PostTradeLISTransactionFlag = new("LRGS");

    /// <summary>Transactions made within the current volume weighted spread reflected on the order book or the quotes of the market makers of the trading venue operating that system</summary>
    [IsoId("_PSn9cWiAEfCsrrIilHxTfw")]
    [Description(@"Transactions made within the current volume weighted spread reflected on the order book or the quotes of the market makers of the trading venue operating that system")]
    public static readonly ExternalPostTrade3Code NegotiatedTransactionInLiquidFinancialInstrumentsFlag = new("NLIQ");

    /// <summary>Non-price forming transactions</summary>
    [IsoId("_JJtecWiAEfCsrrIilHxTfw")]
    [Description(@"Non-price forming transactions")]
    public static readonly ExternalPostTrade3Code NonPriceFormingTransactionFlag = new("NPFT");

    /// <summary>Transaction in an illiquid instrument traded at a system-set percentage of a reference price.</summary>
    [IsoId("_Pxhf8WiAEfCsrrIilHxTfw")]
    [Description(@"Transaction in an illiquid instrument traded at a system-set percentage of a reference price.")]
    public static readonly ExternalPostTrade3Code NegotiatedTransactionInIlliquidFinancialInstrumentsFlag = new("OILQ");

    /// <summary>Transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.
    /// 
    /// It is used against a single lot price and that is not a ‘package transaction' for bonds
    /// 
    /// It is used as a single lot price and that is not a ‘package transaction' for equities</summary>
    [IsoId("_JulGEWiAEfCsrrIilHxTfw")]
    [Description(@"Transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.

It is used against a single lot price and that is not a ‘package transaction' for bonds

It is used as a single lot price and that is not a ‘package transaction' for equities")]
    public static readonly ExternalPostTrade3Code PortfolioTradeFlag = new("PORT");

    /// <summary>Transactions executed subject to conditions other than the current market price of that financial instrument</summary>
    [IsoId("_P6zXwWiAEfCsrrIilHxTfw")]
    [Description(@"Transactions executed subject to conditions other than the current market price of that financial instrument")]
    public static readonly ExternalPostTrade3Code NegotiatedTransactionSubjectToConditionsOtherThanTheCurrentMarketPriceFlag = new("PRIC");

    /// <summary>Transactions which are executed under systems</summary>
    [IsoId("_OTdmgWiAEfCsrrIilHxTfw")]
    [Description(@"Transactions which are executed under systems")]
    public static readonly ExternalPostTrade3Code ReferencePriceTransactionFlag = new("RFPT");

    /// <summary>Transactions where dividends accrue to the non-entitled party due to ex- or cum-dividend timing</summary>
    [IsoId("_MG62cWiAEfCsrrIilHxTfw")]
    [Description(@"Transactions where dividends accrue to the non-entitled party due to ex- or cum-dividend timing")]
    public static readonly ExternalPostTrade3Code SpecialDividendTransactionFlag = new("SDIV");
}
