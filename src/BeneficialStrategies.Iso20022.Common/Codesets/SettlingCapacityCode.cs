// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the party in the settlement of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOkmYdp-Ed-ak6NoX_4Aeg_-1171911201")]
[Description(@"Specifies the role of the party in the settlement of the transaction.")]
[Derivations(typeof(SettlingCapacity1Code),typeof(SettlingCapacity2Code))]
public enum SettlingCapacityCode
{
    /// <summary>
    /// Settlement party is a custodian. It receives/delivers the securities and carries out custodial duties.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ZOkmYtp-Ed-ak6NoX_4Aeg_-1285750267")]
    [Description(@"Settlement party is a custodian. It receives/delivers the securities and carries out custodial duties.")]
    SettlingCustodian,
    
    /// <summary>
    /// Settlement party is trading and settling transactions in financial instruments on behalf of its client(s).
    /// Encoded/decoded by serializers as &quot;SAGE&quot;.
    /// </summary>
    [EnumMember(Value = "SAGE")]
    [IsoId("_ZOkmY9p-Ed-ak6NoX_4Aeg_1834026004")]
    [Description(@"Settlement party is trading and settling transactions in financial instruments on behalf of its client(s).")]
    SettlingAgent,
    
    /// <summary>
    /// Settlement party is settling its own trades.
    /// Encoded/decoded by serializers as &quot;SPRI&quot;.
    /// </summary>
    [EnumMember(Value = "SPRI")]
    [IsoId("_ZOkmZNp-Ed-ak6NoX_4Aeg_1128911389")]
    [Description(@"Settlement party is settling its own trades.")]
    SettlingPrincipal,
    
    /// <summary>
    /// Party settles trades that were simultaneously offset.
    /// Encoded/decoded by serializers as &quot;RISP&quot;.
    /// </summary>
    [EnumMember(Value = "RISP")]
    [IsoId("_pNJUUCW2EeOslcz0TJwprQ")]
    [Description(@"Party settles trades that were simultaneously offset.")]
    SettlingRisklessPrincipal,
    
}
