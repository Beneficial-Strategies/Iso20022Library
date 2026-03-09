// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tax basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZScZx9p-Ed-ak6NoX_4Aeg_678158284")]
[Description(@"Specifies the tax basis.")]
[DerivedFrom(typeof(TaxationBasisCode))]
public enum TaxationBasis4Code
{
    /// <summary>
    /// Charge/tax basis is a lump sum.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_ZScZyNp-Ed-ak6NoX_4Aeg_752961378")]
    [Description(@"Charge/tax basis is a lump sum.")]
    Flat = TaxationBasisCode.Flat, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges/tax basis is per unit of financial instrument.
    /// Encoded/decoded by serializers as &quot;PERU&quot;.
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("_ZSljsNp-Ed-ak6NoX_4Aeg_752961403")]
    [Description(@"Charges/tax basis is per unit of financial instrument.")]
    PerUnit = TaxationBasisCode.PerUnit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge/Commission/tax basis is based on the gross amount.
    /// Encoded/decoded by serializers as &quot;GRAM&quot;.
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_ZSljsdp-Ed-ak6NoX_4Aeg_771431735")]
    [Description(@"Charge/Commission/tax basis is based on the gross amount.")]
    GrossAmount = TaxationBasisCode.GrossAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge/commission/tax basis is based on the net amount.
    /// Encoded/decoded by serializers as &quot;NEAM&quot;.
    /// </summary>
    [EnumMember(Value = "NEAM")]
    [IsoId("_ZSljstp-Ed-ak6NoX_4Aeg_771431777")]
    [Description(@"Charge/commission/tax basis is based on the net amount.")]
    NetAmount = TaxationBasisCode.NetAmount, // same ordinal as derivation source for type conversions
    
}
