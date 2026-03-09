// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQR7ANp-Ed-ak6NoX_4Aeg_-2146072718")]
[Description(@"Defines how an option can be exercised.")]
[DerivedFrom(typeof(OptionStyleCode))]
public enum OptionStyle3Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as &quot;AMER&quot;.
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_aQR7Adp-Ed-ak6NoX_4Aeg_-930718664")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American = OptionStyleCode.American, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_aQR7Atp-Ed-ak6NoX_4Aeg_1489236661")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European = OptionStyleCode.European, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time.
    /// Encoded/decoded by serializers as &quot;ASIA&quot;.
    /// </summary>
    [EnumMember(Value = "ASIA")]
    [IsoId("_aQR7A9p-Ed-ak6NoX_4Aeg_1517866290")]
    [Description(@"Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time.")]
    Asian = OptionStyleCode.Asian, // same ordinal as derivation source for type conversions
    
}
