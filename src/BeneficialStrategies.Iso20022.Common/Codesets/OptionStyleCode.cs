// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQR7BNp-Ed-ak6NoX_4Aeg_195526371")]
[Description(@"Defines how an option can be exercised.")]
[Derivations(
    typeof(OptionStyle7Code),
    typeof(OptionStyle3Code),
    typeof(OptionStyle6Code),
    typeof(OptionStyle5Code),
    typeof(OptionStyle1Code),
    typeof(OptionStyle2Code),
    typeof(OptionStyle4Code)
)]
public enum OptionStyleCode
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as &quot;AMER&quot;.
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_aQR7Bdp-Ed-ak6NoX_4Aeg_-1399661738")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American,

    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_aQR7Btp-Ed-ak6NoX_4Aeg_-1377497386")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European,

    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as &quot;BERM&quot;.
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("_aQR7B9p-Ed-ak6NoX_4Aeg_-1302692663")]
    [Description(
        @"Option that can be exercised on multiple discrete dates prior to, or on expiry date."
    )]
    Bermudan,

    /// <summary>
    /// Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time.
    /// Encoded/decoded by serializers as &quot;ASIA&quot;.
    /// </summary>
    [EnumMember(Value = "ASIA")]
    [IsoId("_aQR7CNp-Ed-ak6NoX_4Aeg_-1004275745")]
    [Description(
        @"Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time."
    )]
    Asian,

    /// <summary>
    /// Option whose exercise style lies somewhere between European options and Bermudan options. The holder can exercise the option at quarterly dates, but not before a set time period (typically one year) has elapsed.
    /// Encoded/decoded by serializers as &quot;CANA&quot;.
    /// </summary>
    [EnumMember(Value = "CANA")]
    [IsoId("_aQbsANp-Ed-ak6NoX_4Aeg_-256225948")]
    [Description(
        @"Option whose exercise style lies somewhere between European options and Bermudan options. The holder can exercise the option at quarterly dates, but not before a set time period (typically one year) has elapsed."
    )]
    Canary,

    /// <summary>
    /// Other type of option style.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YLxWQED8EeW1yage4PQ__A")]
    [Description(@"Other type of option style.")]
    Other,
}
