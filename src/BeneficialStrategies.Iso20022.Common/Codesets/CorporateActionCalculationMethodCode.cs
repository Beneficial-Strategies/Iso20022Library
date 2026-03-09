// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the calculation method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCgCJ9p-Ed-ak6NoX_4Aeg_734426913")]
[Description(@"Specifies the calculation method.")]
[Derivations(typeof(CorporateActionCalculationMethod1Code))]
public enum CorporateActionCalculationMethodCode
{
    /// <summary>
    /// Pro-rata for drawings.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_bCgCKNp-Ed-ak6NoX_4Aeg_833244970")]
    [Description(@"Pro-rata for drawings.")]
    ProRata,
    
    /// <summary>
    /// Lottery for drawings.
    /// Encoded/decoded by serializers as &quot;LOTT&quot;.
    /// </summary>
    [EnumMember(Value = "LOTT")]
    [IsoId("_bCpMENp-Ed-ak6NoX_4Aeg_882190885")]
    [Description(@"Lottery for drawings.")]
    Lottery,
    
    /// <summary>
    /// Reduction of nominal for partial redemption.
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_bCpMEdp-Ed-ak6NoX_4Aeg_1221120970")]
    [Description(@"Reduction of nominal for partial redemption.")]
    NominalReduction,
    
    /// <summary>
    /// Without reduction of nominal (via pool factor) for partial redemption.
    /// Encoded/decoded by serializers as &quot;NNOM&quot;.
    /// </summary>
    [EnumMember(Value = "NNOM")]
    [IsoId("_bCpMEtp-Ed-ak6NoX_4Aeg_-766558628")]
    [Description(@"Without reduction of nominal (via pool factor) for partial redemption.")]
    NoNominalReduction,
    
}
