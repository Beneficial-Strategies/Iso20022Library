// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigated parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U1p9sGKEEeG1ab6Vf7EgPA")]
[Description(@"Specifies the investigated parties.")]
[DerivedFrom(typeof(InvestigatedPartiesCode))]
public enum InvestigatedParties1Code
{
    /// <summary>
    /// Investigated parties are all parties playig a role matching the search criteria.
    /// Encoded/decoded by serializers as &quot;ALLP&quot;.
    /// </summary>
    [EnumMember(Value = "ALLP")]
    [IsoId("_XhTElmKEEeG1ab6Vf7EgPA")]
    [Description(@"Investigated parties are all parties playig a role matching the search criteria.")]
    AllParties = InvestigatedPartiesCode.AllParties, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investigated party is the owner.
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_XmNZxmKEEeG1ab6Vf7EgPA")]
    [Description(@"Investigated party is the owner.")]
    Owner = InvestigatedPartiesCode.Owner, // same ordinal as derivation source for type conversions
    
}
