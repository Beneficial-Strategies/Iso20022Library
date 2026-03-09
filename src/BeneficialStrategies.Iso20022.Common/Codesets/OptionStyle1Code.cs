// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQIxENp-Ed-ak6NoX_4Aeg_-1429214517")]
[Description(@"Defines how an option can be exercised.")]
[DerivedFrom(typeof(OptionStyleCode))]
public enum OptionStyle1Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as &quot;AMER&quot;.
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_aQIxEdp-Ed-ak6NoX_4Aeg_-1241918165")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American = OptionStyleCode.American, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_aQIxEtp-Ed-ak6NoX_4Aeg_-1241918113")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European = OptionStyleCode.European, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as &quot;BERM&quot;.
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("_aQIxE9p-Ed-ak6NoX_4Aeg_-1241918035")]
    [Description(@"Option that can be exercised on multiple discrete dates prior to, or on expiry date.")]
    Bermudan = OptionStyleCode.Bermudan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time.
    /// Encoded/decoded by serializers as &quot;ASIA&quot;.
    /// </summary>
    [EnumMember(Value = "ASIA")]
    [IsoId("_aQIxFNp-Ed-ak6NoX_4Aeg_1546488855")]
    [Description(@"Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time.")]
    Asian = OptionStyleCode.Asian, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option whose exercise style lies somewhere between European options and Bermudan options. The holder can exercise the option at quarterly dates, but not before a set time period (typically one year) has elapsed.
    /// Encoded/decoded by serializers as &quot;CANA&quot;.
    /// </summary>
    [EnumMember(Value = "CANA")]
    [IsoId("_aQIxFdp-Ed-ak6NoX_4Aeg_1546489244")]
    [Description(@"Option whose exercise style lies somewhere between European options and Bermudan options. The holder can exercise the option at quarterly dates, but not before a set time period (typically one year) has elapsed.")]
    Canary = OptionStyleCode.Canary, // same ordinal as derivation source for type conversions
    
}
