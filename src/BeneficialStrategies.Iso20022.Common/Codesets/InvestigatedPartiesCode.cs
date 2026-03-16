// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigated parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2BtERU4-EeGFgOSp_IATnQ")]
[Description(@"Specifies the investigated parties.")]
[Derivations(typeof(InvestigatedParties1Code))]
public enum InvestigatedPartiesCode
{
    /// <summary>
    /// Investigated parties are all parties playig a role matching the search criteria.
    /// Encoded/decoded by serializers as &quot;ALLP&quot;.
    /// </summary>
    [EnumMember(Value = "ALLP")]
    [IsoId("_zQQzLU5FEeGFgOSp_IATnQ")]
    [Description(
        @"Investigated parties are all parties playig a role matching the search criteria."
    )]
    AllParties,

    /// <summary>
    /// Investigated party is the owner.
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_7vHOzU5FEeGFgOSp_IATnQ")]
    [Description(@"Investigated party is the owner.")]
    Owner,
}
