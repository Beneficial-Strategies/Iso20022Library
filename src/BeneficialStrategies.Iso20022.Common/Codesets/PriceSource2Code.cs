// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the source of a price quotation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_l1ruYaB6EeOEyO7fCl8lLA")]
[Description(@"Specifies the source of a price quotation.")]
[DerivedFrom(typeof(PriceSourceCode))]
public enum PriceSource2Code
{
    /// <summary>
    /// Source of price quotation is a fund, eg, transfer agent, fund itself.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_mUejN6B6EeOEyO7fCl8lLA")]
    [Description(@"Source of price quotation is a fund, eg, transfer agent, fund itself.")]
    Fund = PriceSourceCode.Fund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Source of price quotation is a theoretical value based on the market yield.
    /// Encoded/decoded by serializers as &quot;THEO&quot;.
    /// </summary>
    [EnumMember(Value = "THEO")]
    [IsoId("_mUejOaB6EeOEyO7fCl8lLA")]
    [Description(@"Source of price quotation is a theoretical value based on the market yield.")]
    Theoretical = PriceSourceCode.Theoretical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Source of price quotation is an external vendor.
    /// Encoded/decoded by serializers as &quot;VEND&quot;.
    /// </summary>
    [EnumMember(Value = "VEND")]
    [IsoId("_mUejO6B6EeOEyO7fCl8lLA")]
    [Description(@"Source of price quotation is an external vendor.")]
    Vendor = PriceSourceCode.Vendor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Source of price quotation is a stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_KMfvYaB7EeOEyO7fCl8lLA")]
    [Description(@"Source of price quotation is a stock exchange.")]
    StockExchange = PriceSourceCode.StockExchange, // same ordinal as derivation source for type conversions
}
