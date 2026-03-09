// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how a warrant can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yg0vmNp-Ed-ak6NoX_4Aeg_2120180285")]
[Description(@"Defines how a warrant can be exercised.")]
[Derivations(typeof(WarrantStyle1Code))]
public enum WarrantStyleCode
{
    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_Yg95gNp-Ed-ak6NoX_4Aeg_545175896")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European,
    
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as &quot;AMER&quot;.
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_Yg95gdp-Ed-ak6NoX_4Aeg_609455502")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American,
    
    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as &quot;BERM&quot;.
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("_Yg95gtp-Ed-ak6NoX_4Aeg_-565735523")]
    [Description(@"Option that can be exercised on multiple discrete dates prior to, or on expiry date.")]
    Bermudan,
    
}
