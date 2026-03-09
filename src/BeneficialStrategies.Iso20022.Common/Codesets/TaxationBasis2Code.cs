// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tax basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZScZxNp-Ed-ak6NoX_4Aeg_986778431")]
[Description(@"Specifies the tax basis.")]
[DerivedFrom(typeof(TaxationBasisCode))]
public enum TaxationBasis2Code
{
    /// <summary>
    /// Charge/tax basis is a lump sum.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_ZScZxdp-Ed-ak6NoX_4Aeg_986778433")]
    [Description(@"Charge/tax basis is a lump sum.")]
    Flat = TaxationBasisCode.Flat, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges/tax basis is per unit of financial instrument.
    /// Encoded/decoded by serializers as &quot;PERU&quot;.
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("_ZScZxtp-Ed-ak6NoX_4Aeg_986778434")]
    [Description(@"Charges/tax basis is per unit of financial instrument.")]
    PerUnit = TaxationBasisCode.PerUnit, // same ordinal as derivation source for type conversions
    
}
