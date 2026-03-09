// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the current year ISA.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_adZJ-Np-Ed-ak6NoX_4Aeg_948801052")]
[Description(@"Specifies the type of the current year ISA.")]
[DerivedFrom(typeof(ISATypeCode))]
public enum ISAType1Code
{
    /// <summary>
    /// Type of ISA that offers a stocks and shares component only (no cash).
    /// Encoded/decoded by serializers as &quot;MINE&quot;.
    /// </summary>
    [EnumMember(Value = "MINE")]
    [IsoId("_adi68Np-Ed-ak6NoX_4Aeg_1030991907")]
    [Description(@"Type of ISA that offers a stocks and shares component only (no cash).")]
    MiniEquity = ISATypeCode.MiniEquity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of ISA that must offer a stocks and shares component and, optionally, a cash component.
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_adi68dp-Ed-ak6NoX_4Aeg_1030991924")]
    [Description(@"Type of ISA that must offer a stocks and shares component and, optionally, a cash component.")]
    Maxi = ISATypeCode.Maxi, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of ISA that offers a cash component only (no stock).
    /// Encoded/decoded by serializers as &quot;MINC&quot;.
    /// </summary>
    [EnumMember(Value = "MINC")]
    [IsoId("_adi68tp-Ed-ak6NoX_4Aeg_1030991942")]
    [Description(@"Type of ISA that offers a cash component only (no stock).")]
    MiniCash = ISATypeCode.MiniCash, // same ordinal as derivation source for type conversions
    
}
