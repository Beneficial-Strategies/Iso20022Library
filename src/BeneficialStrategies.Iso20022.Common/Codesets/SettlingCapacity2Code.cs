// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the party in the settlement of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4R0NYCW2EeOslcz0TJwprQ")]
[Description(@"Specifies the role of the party in the settlement of the transaction.")]
[DerivedFrom(typeof(SettlingCapacityCode))]
public enum SettlingCapacity2Code
{
    /// <summary>
    /// Settlement party is trading and settling transactions in financial instruments on behalf of its client(s).
    /// Encoded/decoded by serializers as &quot;SAGE&quot;.
    /// </summary>
    [EnumMember(Value = "SAGE")]
    [IsoId("_7ZoS4SW2EeOslcz0TJwprQ")]
    [Description(
        @"Settlement party is trading and settling transactions in financial instruments on behalf of its client(s)."
    )]
    SettlingAgent = SettlingCapacityCode.SettlingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement party is a custodian. It receives/delivers the securities and carries out custodial duties.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_9j2HsSW2EeOslcz0TJwprQ")]
    [Description(
        @"Settlement party is a custodian. It receives/delivers the securities and carries out custodial duties."
    )]
    SettlingCustodian = SettlingCapacityCode.SettlingCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement party is settling its own trades.
    /// Encoded/decoded by serializers as &quot;SPRI&quot;.
    /// </summary>
    [EnumMember(Value = "SPRI")]
    [IsoId("_9rSMcSW2EeOslcz0TJwprQ")]
    [Description(@"Settlement party is settling its own trades.")]
    SettlingPrincipal = SettlingCapacityCode.SettlingPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party settles trades that were simultaneously offset.
    /// Encoded/decoded by serializers as &quot;RISP&quot;.
    /// </summary>
    [EnumMember(Value = "RISP")]
    [IsoId("_9wCwoSW2EeOslcz0TJwprQ")]
    [Description(@"Party settles trades that were simultaneously offset.")]
    SettlingRisklessPrincipal = SettlingCapacityCode.SettlingRisklessPrincipal, // same ordinal as derivation source for type conversions
}
