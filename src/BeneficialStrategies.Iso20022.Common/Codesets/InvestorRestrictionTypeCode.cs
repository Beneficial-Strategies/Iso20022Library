// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies to whom or what the restriction applies.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_adQAAtp-Ed-ak6NoX_4Aeg_935487797")]
[Description(@"Specifies to whom or what the restriction applies.")]
[Derivations(typeof(InvestorRestrictionType1Code))]
public enum InvestorRestrictionTypeCode
{
    /// <summary>
    /// Restriction applies to a legal resident.
    /// Encoded/decoded by serializers as &quot;LERE&quot;.
    /// </summary>
    [EnumMember(Value = "LERE")]
    [IsoId("_adQAA9p-Ed-ak6NoX_4Aeg_1438807698")]
    [Description(@"Restriction applies to a legal resident.")]
    LegalResident,
    
    /// <summary>
    /// Restriction applies to a citizen.
    /// Encoded/decoded by serializers as &quot;CITI&quot;.
    /// </summary>
    [EnumMember(Value = "CITI")]
    [IsoId("_adQABNp-Ed-ak6NoX_4Aeg_1439730879")]
    [Description(@"Restriction applies to a citizen.")]
    Citizen,
    
    /// <summary>
    /// Restriction applies to an individual.
    /// Encoded/decoded by serializers as &quot;INDV&quot;.
    /// </summary>
    [EnumMember(Value = "INDV")]
    [IsoId("_adQABdp-Ed-ak6NoX_4Aeg_1441575812")]
    [Description(@"Restriction applies to an individual.")]
    Individual,
    
}
