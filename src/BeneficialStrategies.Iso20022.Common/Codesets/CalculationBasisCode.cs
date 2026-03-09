// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the calculation basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVa-INp-Ed-ak6NoX_4Aeg_-1889057025")]
[Description(@"Specifies the calculation basis.")]
[Derivations(typeof(CalculationBasis1Code),typeof(CalculationBasis2Code))]
public enum CalculationBasisCode
{
    /// <summary>
    /// Average basis.
    /// Encoded/decoded by serializers as &quot;AVER&quot;.
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("_bVa-Idp-Ed-ak6NoX_4Aeg_-1432837646")]
    [Description(@"Average basis.")]
    Average,
    
    /// <summary>
    /// Daily basis.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_bVa-Itp-Ed-ak6NoX_4Aeg_-1432837628")]
    [Description(@"Daily basis.")]
    Daily,
    
    /// <summary>
    /// Another type of calculation basis.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bVa-I9p-Ed-ak6NoX_4Aeg_-797941073")]
    [Description(@"Another type of calculation basis.")]
    Other,
    
    /// <summary>
    /// Monthly basis.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_bVa-JNp-Ed-ak6NoX_4Aeg_-1394980831")]
    [Description(@"Monthly basis.")]
    Monthly,
    
    /// <summary>
    /// Yearly basis.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_bVa-Jdp-Ed-ak6NoX_4Aeg_-1394980754")]
    [Description(@"Yearly basis.")]
    Annual,
    
}
