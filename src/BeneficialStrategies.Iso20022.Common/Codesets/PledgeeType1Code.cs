// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of pledgee.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ryn6UFj2EeSYweXGddZAOA")]
[Description(@"Specifies the type of pledgee.")]
[DerivedFrom(typeof(PledgeeTypeCode))]
public enum PledgeeType1Code
{
    /// <summary>
    /// Financial instruments are pledged to a counterparty.
    /// Encoded/decoded by serializers as &quot;CPTY&quot;.
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_o56mAVj2EeSYweXGddZAOA")]
    [Description(@"Financial instruments are pledged to a counterparty.")]
    Counterparty = PledgeeTypeCode.Counterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instruments are pledged to a regulatory body.
    /// Encoded/decoded by serializers as &quot;REGB&quot;.
    /// </summary>
    [EnumMember(Value = "REGB")]
    [IsoId("_pCsHgVj2EeSYweXGddZAOA")]
    [Description(@"Financial instruments are pledged to a regulatory body.")]
    RegulatoryBody = PledgeeTypeCode.RegulatoryBody, // same ordinal as derivation source for type conversions
    
}
