// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of executed order in a bidding process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YqDkF9p-Ed-ak6NoX_4Aeg_-897262325")]
[Description(@"Specifies the type of executed order in a bidding process.")]
[DerivedFrom(typeof(TradeTypeCode))]
public enum TradeType2Code
{
    /// <summary>
    /// Trade involving risk.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("_YqDkGNp-Ed-ak6NoX_4Aeg_-865863561")]
    [Description(@"Trade involving risk.")]
    RiskTrade = TradeTypeCode.RiskTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_YqNVENp-Ed-ak6NoX_4Aeg_-865863544")]
    [Description(
        @"Trade whose price is guaranteed as the weighted average of the trade prices on a specific day."
    )]
    VWAPGuarantee = TradeTypeCode.VWAPGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade in which an agent intermediates between a buyer and a seller.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_YqNVEdp-Ed-ak6NoX_4Aeg_-865863526")]
    [Description(@"Trade in which an agent intermediates between a buyer and a seller.")]
    Agency = TradeTypeCode.Agency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade which is guaranteed to be finalized.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_YqNVEtp-Ed-ak6NoX_4Aeg_-865863509")]
    [Description(@"Trade which is guaranteed to be finalized.")]
    GuaranteedClose = TradeTypeCode.GuaranteedClose, // same ordinal as derivation source for type conversions
}
