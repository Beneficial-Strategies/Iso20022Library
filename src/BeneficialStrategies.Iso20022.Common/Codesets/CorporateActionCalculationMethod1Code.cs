// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the calculation method for drawings.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCgCItp-Ed-ak6NoX_4Aeg_-666370508")]
[Description(@"Specifies the calculation method for drawings.")]
[DerivedFrom(typeof(CorporateActionCalculationMethodCode))]
public enum CorporateActionCalculationMethod1Code
{
    /// <summary>
    /// Pro-rata for drawings.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_bCgCI9p-Ed-ak6NoX_4Aeg_-666370477")]
    [Description(@"Pro-rata for drawings.")]
    ProRata = CorporateActionCalculationMethodCode.ProRata, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Lottery for drawings.
    /// Encoded/decoded by serializers as &quot;LOTT&quot;.
    /// </summary>
    [EnumMember(Value = "LOTT")]
    [IsoId("_bCgCJNp-Ed-ak6NoX_4Aeg_-666370476")]
    [Description(@"Lottery for drawings.")]
    Lottery = CorporateActionCalculationMethodCode.Lottery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reduction of nominal for partial redemption.
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_bCgCJdp-Ed-ak6NoX_4Aeg_-666370467")]
    [Description(@"Reduction of nominal for partial redemption.")]
    NominalReduction = CorporateActionCalculationMethodCode.NominalReduction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Without reduction of nominal (via pool factor) for partial redemption.
    /// Encoded/decoded by serializers as &quot;NNOM&quot;.
    /// </summary>
    [EnumMember(Value = "NNOM")]
    [IsoId("_bCgCJtp-Ed-ak6NoX_4Aeg_-666370446")]
    [Description(@"Without reduction of nominal (via pool factor) for partial redemption.")]
    NoNominalReduction = CorporateActionCalculationMethodCode.NoNominalReduction, // same ordinal as derivation source for type conversions
    
}
