// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aUmaVNp-Ed-ak6NoX_4Aeg_-863621443")]
[Description(
    @"Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed."
)]
[DerivedFrom(typeof(MarketTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarketType4Code>))]
#endif
public enum MarketType4Code
{
    /// <summary>
    /// The place is a fund (transfer agent, fund itself, etc.).
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_aUmaVdp-Ed-ak6NoX_4Aeg_-1841693350")]
    [Description(@"The place is a fund (transfer agent, fund itself, etc.).")]
    Fund = MarketTypeCode.Fund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a local market.
    /// Encoded/decoded by serializers as &quot;LMAR&quot;.
    /// </summary>
    [EnumMember(Value = "LMAR")]
    [IsoId("_aUmaVtp-Ed-ak6NoX_4Aeg_-790560278")]
    [Description(@"The place is a local market.")]
    LocalMarket = MarketTypeCode.LocalMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is theoretical.
    /// Encoded/decoded by serializers as &quot;THEO&quot;.
    /// </summary>
    [EnumMember(Value = "THEO")]
    [IsoId("_aUmaV9p-Ed-ak6NoX_4Aeg_1996754313")]
    [Description(@"The place is theoretical.")]
    Theoretical = MarketTypeCode.Theoretical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a vendor.
    /// Encoded/decoded by serializers as &quot;VEND&quot;.
    /// </summary>
    [EnumMember(Value = "VEND")]
    [IsoId("_aUmaWNp-Ed-ak6NoX_4Aeg_-831064220")]
    [Description(@"The place is a vendor.")]
    Vendor = MarketTypeCode.Vendor, // same ordinal as derivation source for type conversions
}
