// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role as an internal party in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__q6voAkhEeWGouz230Xp5Q")]
[Description(@"Specifies the role as an internal party in the transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InternalPartyRole1Code
{
    /// <summary>
    /// Party acting as an internal agent.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_T0-jUR5ZEeWc9bJOIIhUUw")]
    [Description(@"Party acting as an internal agent.")]
    Internal = PartyRoleCode.Internal, // same ordinal as derivation source for type conversions
    
}
