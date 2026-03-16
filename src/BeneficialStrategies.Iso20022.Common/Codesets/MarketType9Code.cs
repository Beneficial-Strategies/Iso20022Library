// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ny1Z8YVYEe-Pv9KR9bv9IA")]
[Description(
    @"Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed."
)]
[DerivedFrom(typeof(MarketTypeCode))]
public enum MarketType9Code
{
    /// <summary>
    /// The place is a fund (transfer agent, fund itself, etc.).
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("")]
    [Description(@"The place is a fund (transfer agent, fund itself, etc.).")]
    Fund = MarketTypeCode.Fund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a local market.
    /// Encoded/decoded by serializers as &quot;LMAR&quot;.
    /// </summary>
    [EnumMember(Value = "LMAR")]
    [IsoId("")]
    [Description(@"The place is a local market.")]
    LocalMarket = MarketTypeCode.LocalMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Source of price quotation is a smart contract automated pricing system.
    /// Encoded/decoded by serializers as &quot;SCAS&quot;.
    /// </summary>
    [EnumMember(Value = "SCAS")]
    [IsoId("")]
    [Description(@"Source of price quotation is a smart contract automated pricing system.")]
    SmartContractAutomatedPricingSystem = MarketTypeCode.SmartContractAutomatedPricingSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is theoretical.
    /// Encoded/decoded by serializers as &quot;THEO&quot;.
    /// </summary>
    [EnumMember(Value = "THEO")]
    [IsoId("")]
    [Description(@"The place is theoretical.")]
    Theoretical = MarketTypeCode.Theoretical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a vendor.
    /// Encoded/decoded by serializers as &quot;VEND&quot;.
    /// </summary>
    [EnumMember(Value = "VEND")]
    [IsoId("")]
    [Description(@"The place is a vendor.")]
    Vendor = MarketTypeCode.Vendor, // same ordinal as derivation source for type conversions
}
