// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the current year ISA.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_adi689p-Ed-ak6NoX_4Aeg_1019974978")]
[Description(@"Specifies the type of the current year ISA.")]
[DerivedFrom(typeof(ISATypeCode))]
public enum ISAType2Code
{
    /// <summary>
    /// Type of ISA that offers a stocks and shares component only (no cash).
    /// Encoded/decoded by serializers as &quot;MINE&quot;.
    /// </summary>
    [EnumMember(Value = "MINE")]
    [IsoId("_adi69Np-Ed-ak6NoX_4Aeg_1019975518")]
    [Description(@"Type of ISA that offers a stocks and shares component only (no cash).")]
    MiniEquity = ISATypeCode.MiniEquity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of ISA that must offer a stocks and shares component and, optionally, a cash component.
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_adi69dp-Ed-ak6NoX_4Aeg_1019975553")]
    [Description(@"Type of ISA that must offer a stocks and shares component and, optionally, a cash component.")]
    Maxi = ISATypeCode.Maxi, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of ISA that offers a cash component only (no stock).
    /// Encoded/decoded by serializers as &quot;MINC&quot;.
    /// </summary>
    [EnumMember(Value = "MINC")]
    [IsoId("_adi69tp-Ed-ak6NoX_4Aeg_1019975613")]
    [Description(@"Type of ISA that offers a cash component only (no stock).")]
    MiniCash = ISATypeCode.MiniCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any ISA.
    /// Encoded/decoded by serializers as &quot;ANYI&quot;.
    /// </summary>
    [EnumMember(Value = "ANYI")]
    [IsoId("_adi699p-Ed-ak6NoX_4Aeg_1076307513")]
    [Description(@"Any ISA.")]
    Any = ISATypeCode.Any, // same ordinal as derivation source for type conversions
    
}
