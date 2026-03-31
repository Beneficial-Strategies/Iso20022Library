// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDPyMLszEeiTr4dQrTCaYA")]
[Description(@"Specifies a type of investment fund transaction.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FundOrderType10Code>))]
#endif
public enum FundOrderType10Code
{
    /// <summary>
    /// Investment fund order is a subscription.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_fPfJIbszEeiTr4dQrTCaYA")]
    [Description(@"Investment fund order is a subscription.")]
    Subscription = FundOrderTypeCode.Subscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a dividend reinvestment (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;RDIV&quot;.
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_f00q0bszEeiTr4dQrTCaYA")]
    [Description(
        @"Investment fund order is a dividend reinvestment (only applicable to a subscription)."
    )]
    ReinvestmentOfDividend = FundOrderTypeCode.ReinvestmentOfDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a redemption.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_gs6wcbszEeiTr4dQrTCaYA")]
    [Description(@"Investment fund order is a redemption.")]
    Redemption = FundOrderTypeCode.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a regular savings plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;RGSV&quot;.
    /// </summary>
    [EnumMember(Value = "RGSV")]
    [IsoId("_hNyo4bszEeiTr4dQrTCaYA")]
    [Description(
        @"Investment fund order is a regular savings plan (only applicable to a subscription)."
    )]
    RegularSavingsPlan = FundOrderTypeCode.RegularSavingsPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is for a withdrawal investment plan (only applicable to a redemption).
    /// Encoded/decoded by serializers as &quot;WIDP&quot;.
    /// </summary>
    [EnumMember(Value = "WIDP")]
    [IsoId("_hpd4QbszEeiTr4dQrTCaYA")]
    [Description(
        @"Investment fund order is for a withdrawal investment plan (only applicable to a redemption)."
    )]
    Withdrawal = FundOrderTypeCode.Withdrawal, // same ordinal as derivation source for type conversions
}
