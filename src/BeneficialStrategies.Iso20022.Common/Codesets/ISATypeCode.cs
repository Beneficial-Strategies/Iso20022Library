// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the current year ISA.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_adi6-Np-Ed-ak6NoX_4Aeg_277587694")]
[Description(@"Specifies the type of the current year ISA.")]
[Derivations(typeof(ISAType1Code), typeof(ISAType2Code))]
public enum ISATypeCode
{
    /// <summary>
    /// Type of ISA that offers a stocks and shares component only (no cash).
    /// Encoded/decoded by serializers as &quot;MINE&quot;.
    /// </summary>
    [EnumMember(Value = "MINE")]
    [IsoId("_adsE4Np-Ed-ak6NoX_4Aeg_391181286")]
    [Description(@"Type of ISA that offers a stocks and shares component only (no cash).")]
    MiniEquity,

    /// <summary>
    /// Type of ISA that must offer a stocks and shares component and, optionally, a cash component.
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_adsE4dp-Ed-ak6NoX_4Aeg_421659448")]
    [Description(
        @"Type of ISA that must offer a stocks and shares component and, optionally, a cash component."
    )]
    Maxi,

    /// <summary>
    /// Type of ISA that offers a cash component only (no stock).
    /// Encoded/decoded by serializers as &quot;MINC&quot;.
    /// </summary>
    [EnumMember(Value = "MINC")]
    [IsoId("_adsE4tp-Ed-ak6NoX_4Aeg_1575662850")]
    [Description(@"Type of ISA that offers a cash component only (no stock).")]
    MiniCash,

    /// <summary>
    /// Any ISA.
    /// Encoded/decoded by serializers as &quot;ANYI&quot;.
    /// </summary>
    [EnumMember(Value = "ANYI")]
    [IsoId("_adsE49p-Ed-ak6NoX_4Aeg_749358612")]
    [Description(@"Any ISA.")]
    Any,
}
