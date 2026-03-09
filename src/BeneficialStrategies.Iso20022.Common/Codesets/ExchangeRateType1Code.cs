// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aksr2Np-Ed-ak6NoX_4Aeg_-75535887")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(ExchangeRateTypeCode))]
public enum ExchangeRateType1Code
{
    /// <summary>
    /// Exchange rate applied is the spot rate.
    /// Encoded/decoded by serializers as &quot;SPOT&quot;.
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_ak11wNp-Ed-ak6NoX_4Aeg_-75535808")]
    [Description(@"Exchange rate applied is the spot rate.")]
    Spot = ExchangeRateTypeCode.Spot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange rate applied is the market rate at the time of the sale.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_ak11wdp-Ed-ak6NoX_4Aeg_-75535501")]
    [Description(@"Exchange rate applied is the market rate at the time of the sale.")]
    Sale = ExchangeRateTypeCode.Sale, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange rate applied is the rate agreed between the parties.
    /// Encoded/decoded by serializers as &quot;AGRD&quot;.
    /// </summary>
    [EnumMember(Value = "AGRD")]
    [IsoId("_ak11wtp-Ed-ak6NoX_4Aeg_-75535484")]
    [Description(@"Exchange rate applied is the rate agreed between the parties.")]
    Agreed = ExchangeRateTypeCode.Agreed, // same ordinal as derivation source for type conversions
    
}
