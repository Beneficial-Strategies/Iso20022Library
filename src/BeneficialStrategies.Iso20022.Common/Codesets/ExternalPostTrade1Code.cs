// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information related to the post trade of bonds
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org. Versioned restriction of <see cref="ExternalPostTradeCode"/> — a bonds-specific subset of the base codeset's wire values; each member below carries its own IsoId distinct from the base codeset's IsoId for the same wire code, per CLAUDE.md's hybrid-pattern guidance. No length facet published by MCP for this codeset; Pattern kept at the conventional 1-4 character range observed across all published member codes.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_dGMAgGhrEfCsrrIilHxTfw")]
[Description(@"Information related to the post trade of bonds")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTrade1Code>))]
public readonly struct ExternalPostTrade1Code : IIsoExternalCode, IEquatable<ExternalPostTrade1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTrade1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTrade1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTrade1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTrade1Code"/>.</summary>
    public static implicit operator ExternalPostTrade1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTrade1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTrade1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTrade1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTrade1Code a, ExternalPostTrade1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTrade1Code a, ExternalPostTrade1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTrade1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTrade1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTrade1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTrade1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Publication of four-week aggregated transactions applicable to bonds</summary>
    [IsoId("_OQr0wWh_EfCsrrIilHxTfw")]
    [Description(@"Publication of four-week aggregated transactions applicable to bonds")]
    public static readonly ExternalPostTrade1Code FourWeeksAggregationBondFlag = new("AGFW");

    /// <summary>When a previously published transaction is amended.</summary>
    [IsoId("_fxxs8Wh_EfCsrrIilHxTfw")]
    [Description(@"When a previously published transaction is amended.")]
    public static readonly ExternalPostTrade1Code AmendmentFlag = new("AMND");

    /// <summary>Transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.</summary>
    [IsoId("_9wQIUWh-EfCsrrIilHxTfw")]
    [Description(@"Transactions executed in reference to a price that is calculated over multiple time instances according to a given benchmark.")]
    public static readonly ExternalPostTrade1Code BenchmarkTransactionsFlag = new("BENC");

    /// <summary>When a previously published transaction is cancelled.</summary>
    [IsoId("_fpj8MWhrEfCsrrIilHxTfw")]
    [Description(@"When a previously published transaction is cancelled.")]
    public static readonly ExternalPostTrade1Code CancellationFlag = new("CANC");

    /// <summary>Individual transactions in sovereign bonds which have previously benefited from aggregated publication</summary>
    [IsoId("_PWXqcWh_EfCsrrIilHxTfw")]
    [Description(@"Individual transactions in sovereign bonds which have previously benefited from aggregated publication")]
    public static readonly ExternalPostTrade1Code FullDetailsFlagG = new("FULG");

    /// <summary>Transaction in a sovereign bond which has previously benefitted from the omission of the publication of the volume</summary>
    [IsoId("_hfEFQWhrEfCsrrIilHxTfw")]
    [Description(@"Transaction in a sovereign bond which has previously benefitted from the omission of the publication of the volume")]
    public static readonly ExternalPostTrade1Code FullDetailsFlagO = new("FULO");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is not a liquid market</summary>
    [IsoId("_hY9dQWhrEfCsrrIilHxTfw")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is not a liquid market")]
    public static readonly ExternalPostTrade1Code LargeIlliquidFlag = new("LIF4");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is a liquid market</summary>
    [IsoId("_f98QwWhrEfCsrrIilHxTfw")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a large size in a financial instrument for which there is a liquid market")]
    public static readonly ExternalPostTrade1Code LargeLiquidFlag = new("LLF3");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is not a liquid market</summary>
    [IsoId("_gODJUWhrEfCsrrIilHxTfw")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is not a liquid market")]
    public static readonly ExternalPostTrade1Code MediumIlliquidFlag = new("MIF2");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is a liquid market</summary>
    [IsoId("_gQ96cWhrEfCsrrIilHxTfw")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a medium size in a financial instrument for which there is a liquid market")]
    public static readonly ExternalPostTrade1Code MediumLiquidFlag = new("MLF1");

    /// <summary>Matched principal transactions</summary>
    [IsoId("_gLVMgWhrEfCsrrIilHxTfw")]
    [Description(@"Matched principal transactions")]
    public static readonly ExternalPostTrade1Code MatchedPrincipalTradingFlag = new("MTCH");

    /// <summary>Transactions which are negotiated privately but reported under the rules of a trading venue.</summary>
    [IsoId("_gUAAUWhrEfCsrrIilHxTfw")]
    [Description(@"Transactions which are negotiated privately but reported under the rules of a trading venue.")]
    public static readonly ExternalPostTrade1Code NegotiatedTransactionFlag = new("NEGO");

    /// <summary>Non-price forming transactions</summary>
    [IsoId("_gWhI0WhrEfCsrrIilHxTfw")]
    [Description(@"Non-price forming transactions")]
    public static readonly ExternalPostTrade1Code NonPriceFormingTransactionFlag = new("NPFT");

    /// <summary>Transaction in a sovereign bond which benefits from the omission of the publication of the volume</summary>
    [IsoId("_gq9HwWhrEfCsrrIilHxTfw")]
    [Description(@"Transaction in a sovereign bond which benefits from the omission of the publication of the volume")]
    public static readonly ExternalPostTrade1Code VolumeOmissionBondFlag = new("OMIS");

    /// <summary>Transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.
    /// 
    /// It is used against a single lot price and that is not a ‘package transaction' for bonds
    /// 
    /// It is used as a single lot price and that is not a ‘package transaction' for equities</summary>
    [IsoId("_gdX-wWhrEfCsrrIilHxTfw")]
    [Description(@"Transactions in five or more different financial instruments where those transactions are traded at the same time by the same client.

It is used against a single lot price and that is not a ‘package transaction' for bonds

It is used as a single lot price and that is not a ‘package transaction' for equities")]
    public static readonly ExternalPostTrade1Code PortfolioTradeFlag = new("PORT");

    /// <summary>Package transactions, which are not exchange for physicals</summary>
    [IsoId("_HRzgoWiLEfCck_UMhds_YA")]
    [Description(@"Package transactions, which are not exchange for physicals")]
    public static readonly ExternalPostTrade1Code PackageTransactionFlag = new("TPAC");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is not a liquid market</summary>
    [IsoId("_gk7_UWhrEfCsrrIilHxTfw")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is not a liquid market")]
    public static readonly ExternalPostTrade1Code VeryLargeIlliquidFlag = new("VIF5");

    /// <summary>Transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is a liquid market</summary>
    [IsoId("_ghBvsWhrEfCsrrIilHxTfw")]
    [Description(@"Transactions in bonds benefiting from a deferral applicable to transactions of a very large size in a financial instrument for which there is a liquid market")]
    public static readonly ExternalPostTrade1Code VeryLargeLiquidFlag = new("VLF5");

    /// <summary>Exchange for physicals</summary>
    [IsoId("_fsqTgWhrEfCsrrIilHxTfw")]
    [Description(@"Exchange for physicals")]
    public static readonly ExternalPostTrade1Code ExchangeForPhysicalsTransactionFlag = new("XPFH");
}
