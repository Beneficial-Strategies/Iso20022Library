// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides details on the  type of the cash reinvestment in a given currency.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TstrIMkgEeeiAIB1i4AlQw")]
[Description(@"Provides details on the  type of the cash reinvestment in a given currency.")]
[DerivedFrom(typeof(ReinvestmentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReinvestmentType1Code>))]
#endif
public enum ReinvestmentType1Code
{
    /// <summary>
    /// Other type of reinvestment.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_U2eIgckgEeeiAIB1i4AlQw")]
    [Description(@"Other type of reinvestment.")]
    Other = ReinvestmentTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reinvestment type is a pool of commingled assets.
    /// Encoded/decoded by serializers as &quot;OCMP&quot;.
    /// </summary>
    [EnumMember(Value = "OCMP")]
    [IsoId("_U8uhgskgEeeiAIB1i4AlQw")]
    [Description(@"Reinvestment type is a pool of commingled assets.")]
    OtherCommingledPool = ReinvestmentTypeCode.OtherCommingledPool, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reinvestment type is registered money market fund that is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund.
    /// Encoded/decoded by serializers as &quot;MMFT&quot;.
    /// </summary>
    [EnumMember(Value = "MMFT")]
    [IsoId("_VAKQAckgEeeiAIB1i4AlQw")]
    [Description(
        @"Reinvestment type is registered money market fund that is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund."
    )]
    RegisteredMoneyMarketFund = ReinvestmentTypeCode.RegisteredMoneyMarketFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reinvestment type is market where repurchase agreements are traded.
    /// Encoded/decoded by serializers as &quot;REPM&quot;.
    /// </summary>
    [EnumMember(Value = "REPM")]
    [IsoId("_VIzOoskgEeeiAIB1i4AlQw")]
    [Description(@"Reinvestment type is market where repurchase agreements are traded. ")]
    RepurchaseAgreementMarket = ReinvestmentTypeCode.RepurchaseAgreementMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reinvestment type is direct purchase of securities.
    /// Encoded/decoded by serializers as &quot;SDPU&quot;.
    /// </summary>
    [EnumMember(Value = "SDPU")]
    [IsoId("_VPz1kskgEeeiAIB1i4AlQw")]
    [Description(@"Reinvestment type is direct purchase of securities.")]
    SecuritiesDirectPurchase = ReinvestmentTypeCode.SecuritiesDirectPurchase, // same ordinal as derivation source for type conversions
}
