// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// In the case where the reporting counterparty is a UCIT or AIF, an indication whether it is an ETF or a MMF.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e_zPoFKVEee26cwI-oG0JQ")]
[Description(
    @"In the case where the reporting counterparty is a UCIT or AIF, an indication whether it is an ETF or a MMF."
)]
[DerivedFrom(typeof(FundTypeCode))]
public enum FundType2Code
{
    /// <summary>
    /// Fund of which at least one unit or share class is traded throughout the day on at
    /// least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value.|
    /// Encoded/decoded by serializers as &quot;ETFT&quot;.
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_gipicVKVEee26cwI-oG0JQ")]
    [Description(
        @"Fund of which at least one unit or share class is traded throughout the day on at|least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value.||"
    )]
    ExchangeTradedFund = FundTypeCode.ExchangeTradedFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indication that a fund is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund.
    /// Encoded/decoded by serializers as &quot;MMFT&quot;.
    /// </summary>
    [EnumMember(Value = "MMFT")]
    [IsoId("_gowxgVKVEee26cwI-oG0JQ")]
    [Description(
        @"Indication that a fund is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund."
    )]
    MoneyMarketFund = FundTypeCode.MoneyMarketFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of an investment fund.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_gukekVKVEee26cwI-oG0JQ")]
    [Description(@"Other type of an investment fund. ")]
    Other = FundTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Listed real investment company.
    /// Encoded/decoded by serializers as &quot;REIT&quot;.
    /// </summary>
    [EnumMember(Value = "REIT")]
    [IsoId("_g0YysVKVEee26cwI-oG0JQ")]
    [Description(@"Listed real investment company.")]
    RealEstateInvestmentTrust = FundTypeCode.RealEstateInvestmentTrust, // same ordinal as derivation source for type conversions
}
