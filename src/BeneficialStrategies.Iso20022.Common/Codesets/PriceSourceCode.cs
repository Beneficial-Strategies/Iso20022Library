// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the source of a price quotation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJIKI9p-Ed-ak6NoX_4Aeg_-1943381521")]
[Description(@"Specifies the source of a price quotation.")]
[Derivations(typeof(PriceSource1Code),typeof(PriceSource2Code))]
public enum PriceSourceCode
{
    /// <summary>
    /// Source of price quotation is a fund, eg, transfer agent, fund itself.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_aJIKJNp-Ed-ak6NoX_4Aeg_-1823324851")]
    [Description(@"Source of price quotation is a fund, eg, transfer agent, fund itself.")]
    Fund,
    
    /// <summary>
    /// Source of price quotation is a theoretical value based on the market yield.
    /// Encoded/decoded by serializers as &quot;THEO&quot;.
    /// </summary>
    [EnumMember(Value = "THEO")]
    [IsoId("_aJIKJdp-Ed-ak6NoX_4Aeg_-1823324834")]
    [Description(@"Source of price quotation is a theoretical value based on the market yield.")]
    Theoretical,
    
    /// <summary>
    /// Source of price quotation is an external vendor.
    /// Encoded/decoded by serializers as &quot;VEND&quot;.
    /// </summary>
    [EnumMember(Value = "VEND")]
    [IsoId("_aJIKJtp-Ed-ak6NoX_4Aeg_-1823324816")]
    [Description(@"Source of price quotation is an external vendor.")]
    Vendor,
    
    /// <summary>
    /// Source of price quotation is a stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_5_16kKB6EeOEyO7fCl8lLA")]
    [Description(@"Source of price quotation is a stock exchange.")]
    StockExchange,
    
}
