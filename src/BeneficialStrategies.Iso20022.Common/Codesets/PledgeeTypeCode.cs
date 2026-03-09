// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of pledgee.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fynYkE9ZEeSn2-3swbRbzg")]
[Description(@"Specifies the type of pledgee.")]
[Derivations(typeof(PledgeeType1Code))]
public enum PledgeeTypeCode
{
    /// <summary>
    /// Financial instruments are pledged to a regulatory body.
    /// Encoded/decoded by serializers as &quot;REGB&quot;.
    /// </summary>
    [EnumMember(Value = "REGB")]
    [IsoId("_J-JKME9aEeSn2-3swbRbzg")]
    [Description(@"Financial instruments are pledged to a regulatory body.")]
    RegulatoryBody,
    
    /// <summary>
    /// Financial instruments are pledged to a counterparty.
    /// Encoded/decoded by serializers as &quot;CPTY&quot;.
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_0CJM8E9ZEeSn2-3swbRbzg")]
    [Description(@"Financial instruments are pledged to a counterparty.")]
    Counterparty,
    
}
