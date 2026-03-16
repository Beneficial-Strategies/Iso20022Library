// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tax basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vg5awdp-Ed-ak6NoX_4Aeg_-372135531")]
[Description(@"Specifies the tax basis.")]
[DerivedFrom(typeof(TaxationBasisCode))]
public enum TaxationBasis3Code
{
    /// <summary>
    /// Charge/tax basis is a lump sum.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_Vg5awtp-Ed-ak6NoX_4Aeg_1288355632")]
    [Description(@"Charge/tax basis is a lump sum.")]
    Flat = TaxationBasisCode.Flat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges/tax basis is per unit of financial instrument.
    /// Encoded/decoded by serializers as &quot;PERU&quot;.
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("_Vg5aw9p-Ed-ak6NoX_4Aeg_1297589258")]
    [Description(@"Charges/tax basis is per unit of financial instrument.")]
    PerUnit = TaxationBasisCode.PerUnit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type of taxation basis.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vg5axNp-Ed-ak6NoX_4Aeg_1301284529")]
    [Description(@"Another type of taxation basis.")]
    Other = TaxationBasisCode.Other, // same ordinal as derivation source for type conversions
}
