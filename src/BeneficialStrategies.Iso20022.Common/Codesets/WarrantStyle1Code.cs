// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yg0vlNp-Ed-ak6NoX_4Aeg_-1700057033")]
[Description(@"Defines how an option can be exercised.")]
[DerivedFrom(typeof(WarrantStyleCode))]
public enum WarrantStyle1Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as &quot;AMER&quot;.
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_Yg0vldp-Ed-ak6NoX_4Aeg_1980293018")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American = WarrantStyleCode.American, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_Yg0vltp-Ed-ak6NoX_4Aeg_-1236653940")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European = WarrantStyleCode.European, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as &quot;BERM&quot;.
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("_Yg0vl9p-Ed-ak6NoX_4Aeg_230494823")]
    [Description(
        @"Option that can be exercised on multiple discrete dates prior to, or on expiry date."
    )]
    Bermudan = WarrantStyleCode.Bermudan, // same ordinal as derivation source for type conversions
}
