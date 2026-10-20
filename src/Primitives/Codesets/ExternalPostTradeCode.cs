// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Flags related to the post trade report
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org. No length facet published by MCP for this codeset; Pattern kept at the conventional 1-4 character range observed across all published member codes.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_89rE4GIoEfCeoPFCHQnhvA")]
[Description(@"Flags related to the post trade report")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTradeCode>))]
public readonly struct ExternalPostTradeCode : IIsoExternalCode, IEquatable<ExternalPostTradeCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTradeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTradeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTradeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTradeCode"/>.</summary>
    public static implicit operator ExternalPostTradeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTradeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTradeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTradeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeCode a, ExternalPostTradeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeCode a, ExternalPostTradeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTradeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTradeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Publication of four-week aggregated transactions applicable to bonds</summary>
    [IsoId("_6V1qgGIpEfCeoPFCHQnhvA")]
    [Description(@"Publication of four-week aggregated transactions applicable to bonds")]
    public static readonly ExternalPostTradeCode FourWeeksAggregationBondFlag = new("AGFW");

    /// <summary>Transactions executed as a result of an investment firm engaging in algorithmic trading</summary>
    [IsoId("_KbkXoGhvEfCsrrIilHxTfw")]
    [Description(@"Transactions executed as a result of an investment firm engaging in algorithmic trading")]
    public static readonly ExternalPostTradeCode AlgorithmicTransactionFlag = new("ALGO");

    /// <summary>When a previously published transaction is amended.</summary>
    [IsoId("_A3g1gGIvEfCeoPFCHQnhvA")]
    [Description(@"When a previously published transaction is amended.")]
    public static readonly ExternalPostTradeCode AmendmentFlag = new("AMND");

    /// <summary>Transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.</summary>
    [IsoId("_jjeQMGhvEfCsrrIilHxTfw")]
    [Description(@"Transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.")]
    public static readonly ExternalPostTradeCode BenchmarkTransactionsFlag = new("BENC");

    /// <summary>When a previously published transaction is cancelled.</summary>
    [IsoId("_51qjYGIuEfCeoPFCHQnhvA")]
    [Description(@"When a previously published transaction is cancelled.")]
    public static readonly ExternalPostTradeCode CancellationFlag = new("CANC");

    /// <summary>Transactions that are contingent on the purchase, sale, creation or redemption of a derivative contract or other financial instrument where all the components of the trade are meant to be executed as a single lot.</summary>
    [IsoId("_ljj4oGhvEfCsrrIilHxTfw")]
    [Description(@"Transactions that are contingent on the purchase, sale, creation or redemption of a derivative contract or other financial instrument where all the components of the trade are meant to be executed as a single lot.")]
    public static readonly ExternalPostTradeCode ContingentTransactionsFlag = new("CONT");

    /// <summary>Publication of daily aggregated transaction</summary>
    [IsoId("_qDmKwGhuEfCsrrIilHxTfw")]
    [Description(@"Publication of daily aggregated transaction")]
    public static readonly ExternalPostTradeCode DailyAggregatedTransactionFlag = new("DATF");

    /// <summary>Transactions in ETCs, ETNs, SFPs and emission allowances, which benefit from a deferral.</summary>
    [IsoId("_uZtcIGh-EfCsrrIilHxTfw")]
    [Description(@"Transactions in ETCs, ETNs, SFPs and emission allowances, which benefit from a deferral.")]
    public static readonly ExternalPostTradeCode DeferralFlag = new("DEFF");

    /// <summary>Individual transactions for which aggregated details have been previously published</summary>
    [IsoId("_fCDv8GhuEfCsrrIilHxTfw")]
    [Description(@"Individual transactions for which aggregated details have been previously published")]
    public static readonly ExternalPostTradeCode FullDetailsFlagA = new("FULA");

    /// <summary>Transaction for which limited details have been previously published</summary>
    [IsoId("_K1z14GhqEfCsrrIilHxTfw")]
    [Description(@"Transaction for which limited details have been previously published")]
    public static readonly ExternalPostTradeCode FullDetailsFlagF = new("FULF");

    /// <summary>Individual transactions in sovereign bonds which have previously benefited from aggregated publication</summary>
    [IsoId("_Ca8wcGIqEfCeoPFCHQnhvA")]
    [Description(@"Individual transactions in sovereign bonds which have previously benefited from aggregated publication")]
    public static readonly ExternalPostTradeCode FullDetailsFlagG = new("FULG");

    /// <summary>Individual transactions which have previously benefited from aggregated publication.</summary>
    [IsoId("_mb0LwGhuEfCsrrIilHxTfw")]
    [Description(@"Individual transactions which have previously benefited from aggregated publication.")]
    public static readonly ExternalPostTradeCode FullDetailsFlagJ = new("FULJ");

    /// <summary>Transaction in a sovereign bond which has previously benefitted from the omission of the publication of the volume</summary>
    [IsoId("_0zAUEGIpEfCeoPFCHQnhvA")]
    [Description(@"Transaction in a sovereign bond which has previously benefitted from the omission of the publication of the volume")]
    public static readonly ExternalPostTradeCode FullDetailsFlagO = new("FULO");

    /// <summary>Transaction for which limited details have been previously published</summary>
    [IsoId("_hizOYGhuEfCsrrIilHxTfw")]
    [Description(@"Transaction for which limited details have been previously published")]
    public static readonly ExternalPostTradeCode FullDetailsFlagV = new("FULV");

    /// <summary>Publication of aggregated transactions.</summary>
    [IsoId("_r_kvQGhuEfCsrrIilHxTfw")]
    [Description(@"Publication of aggregated transactions.")]
    public static readonly ExternalPostTradeCode FourWeeksAggregationDerivativeFlag = new("FWAF");

    /// <summary>Transactions executed under the deferral for instruments for which there is not a liquid market</summary>
    [IsoId("_3wpwoGhuEfCsrrIilHxTfw")]
    [Description(@"Transactions executed under the deferral for instruments for which there is not a liquid market")]
    public static readonly ExternalPostTradeCode IlliquidInstrumentTransactionFlag = new("ILQD");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is not a liquid market</summary>
    [IsoId("_ZmyaYGIpEfCeoPFCHQnhvA")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is not a liquid market")]
    public static readonly ExternalPostTradeCode LargeIlliquidFlag = new("LIF4");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is a liquid market</summary>
    [IsoId("_WViFAGIpEfCeoPFCHQnhvA")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is a liquid market")]
    public static readonly ExternalPostTradeCode LargeLiquidFlag = new("LLF3");

    /// <summary>First report with publication of limited details</summary>
    [IsoId("_5st0sGhuEfCsrrIilHxTfw")]
    [Description(@"First report with publication of limited details")]
    public static readonly ExternalPostTradeCode LimitedDetailsFlag = new("LMTF");

    /// <summary>Transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.</summary>
    [IsoId("_-l-CoGhuEfCsrrIilHxTfw")]
    [Description(@"Transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.")]
    public static readonly ExternalPostTradeCode PostTradeLISTransactionFlag = new("LRGS");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is not a liquid market</summary>
    [IsoId("_SxbFEGIpEfCeoPFCHQnhvA")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is not a liquid market")]
    public static readonly ExternalPostTradeCode MediumIlliquidFlag = new("MIF2");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is a liquid market</summary>
    [IsoId("_Pvu1sGIpEfCeoPFCHQnhvA")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is a liquid market")]
    public static readonly ExternalPostTradeCode MediumLiquidFlag = new("MLF1");

    /// <summary>Matched principal transactions</summary>
    [IsoId("_M-KeQGIvEfCeoPFCHQnhvA")]
    [Description(@"Matched principal transactions")]
    public static readonly ExternalPostTradeCode MatchedPrincipalTradingFlag = new("MTCH");

    /// <summary>Transactions which are negotiated privately but reported under the rules of a trading venue.</summary>
    [IsoId("_TRsR0GIvEfCeoPFCHQnhvA")]
    [Description(@"Transactions which are negotiated privately but reported under the rules of a trading venue.")]
    public static readonly ExternalPostTradeCode NegotiatedTransactionFlag = new("NEGO");

    /// <summary>Transactions made within the current volume weighted spread reflected on the order book or the quotes of the market makers of the trading venue operating that system</summary>
    [IsoId("_urWjkGhvEfCsrrIilHxTfw")]
    [Description(@"Transactions made within the current volume weighted spread reflected on the order book or the quotes of the market makers of the trading venue operating that system")]
    public static readonly ExternalPostTradeCode NegotiatedTransactionInLiquidFinancialInstrumentsFlag = new("NLIQ");

    /// <summary>Non-price forming transactions</summary>
    [IsoId("_VMJBwGIuEfCeoPFCHQnhvA")]
    [Description(@"Non-price forming transactions")]
    public static readonly ExternalPostTradeCode NonPriceFormingTransactionFlag = new("NPFT");

    /// <summary>Transaction in an illiquid instrument traded at a system-set percentage of a reference price.</summary>
    [IsoId("_rT1OIGhvEfCsrrIilHxTfw")]
    [Description(@"Transaction in an illiquid instrument traded at a system-set percentage of a reference price.")]
    public static readonly ExternalPostTradeCode NegotiatedTransactionInIlliquidFinancialInstrumentsFlag = new("OILQ");

    /// <summary>Transaction in a sovereign bond which benefits from the omission of the publication of the volume</summary>
    [IsoId("_ureVIGIpEfCeoPFCHQnhvA")]
    [Description(@"Transaction in a sovereign bond which benefits from the omission of the publication of the volume")]
    public static readonly ExternalPostTradeCode VolumeOmissionBondFlag = new("OMIS");

    /// <summary>Transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.
    /// 
    /// It is used against a single lot price and that is not a ‘package transaction' for bonds
    /// 
    /// It is used as a single lot price and that is not a ‘package transaction' for equities</summary>
    [IsoId("_m5psYGhwEfCsrrIilHxTfw")]
    [Description(@"Transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.

It is used against a single lot price and that is not a ‘package transaction' for bonds

It is used as a single lot price and that is not a ‘package transaction' for equities")]
    public static readonly ExternalPostTradeCode PortfolioTradeFlag = new("PORT");

    /// <summary>Transactions executed subject to conditions other than the current market price of that financial instrument</summary>
    [IsoId("_xXkSMGhvEfCsrrIilHxTfw")]
    [Description(@"Transactions executed subject to conditions other than the current market price of that financial instrument")]
    public static readonly ExternalPostTradeCode NegotiatedTransactionSubjectToConditionsOtherThanTheCurrentMarketPriceFlag = new("PRIC");

    /// <summary>Transactions which are executed under systems</summary>
    [IsoId("_C2eZEGhwEfCsrrIilHxTfw")]
    [Description(@"Transactions which are executed under systems")]
    public static readonly ExternalPostTradeCode ReferencePriceTransactionFlag = new("RFPT");

    /// <summary>Transactions where dividends accrue to the non-entitled party due to ex- or cum-dividend timing</summary>
    [IsoId("_F_0IkGhwEfCsrrIilHxTfw")]
    [Description(@"Transactions where dividends accrue to the non-entitled party due to ex- or cum-dividend timing")]
    public static readonly ExternalPostTradeCode SpecialDividendTransactionFlag = new("SDIV");

    /// <summary>Transactions executed under the post-trade size specific to the instrument deferral</summary>
    [IsoId("_CrcDMGhvEfCsrrIilHxTfw")]
    [Description(@"Transactions executed under the post-trade size specific to the instrument deferral")]
    public static readonly ExternalPostTradeCode PostTradeSSTITransactionFlag = new("SIZE");

    /// <summary>Package transactions, which are not exchange for physicals</summary>
    [IsoId("_sBclkGIuEfCeoPFCHQnhvA")]
    [Description(@"Package transactions, which are not exchange for physicals")]
    public static readonly ExternalPostTradeCode PackageTransactionFlag = new("TPAC");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is not a liquid market</summary>
    [IsoId("_nLOPwGIpEfCeoPFCHQnhvA")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is not a liquid market")]
    public static readonly ExternalPostTradeCode VeryLargeIlliquidFlag = new("VIF5");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is a liquid market</summary>
    [IsoId("_ja0gQGIpEfCeoPFCHQnhvA")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is a liquid market")]
    public static readonly ExternalPostTradeCode VeryLargeLiquidFlag = new("VLF5");

    /// <summary>Transaction for which limited details are published.</summary>
    [IsoId("_GAIuIGhvEfCsrrIilHxTfw")]
    [Description(@"Transaction for which limited details are published.")]
    public static readonly ExternalPostTradeCode VolumeOmissionDerivativeFlag = new("VOLO");

    /// <summary>Exchange for physicals</summary>
    [IsoId("_zE4zIGIuEfCeoPFCHQnhvA")]
    [Description(@"Exchange for physicals")]
    public static readonly ExternalPostTradeCode ExchangeForPhysicalsTransactionFlag = new("XPFH");
}
