// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the party in the settlement of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOa1Zdp-Ed-ak6NoX_4Aeg_-1034938036")]
[Description(@"Specifies the role of the party in the settlement of the transaction.")]
[DerivedFrom(typeof(SettlingCapacityCode))]
public enum SettlingCapacity1Code
{
    /// <summary>
    /// Settlement party is a custodian. It receives/delivers the securities and carries out custodial duties.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ZOa1Ztp-Ed-ak6NoX_4Aeg_-1857712848")]
    [Description(@"Settlement party is a custodian. It receives/delivers the securities and carries out custodial duties.")]
    SettlingCustodian = SettlingCapacityCode.SettlingCustodian, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement party is trading and settling transactions in financial instruments on behalf of its client(s).
    /// Encoded/decoded by serializers as &quot;SAGE&quot;.
    /// </summary>
    [EnumMember(Value = "SAGE")]
    [IsoId("_ZOa1Z9p-Ed-ak6NoX_4Aeg_593301523")]
    [Description(@"Settlement party is trading and settling transactions in financial instruments on behalf of its client(s).")]
    SettlingAgent = SettlingCapacityCode.SettlingAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement party is settling its own trades.
    /// Encoded/decoded by serializers as &quot;SPRI&quot;.
    /// </summary>
    [EnumMember(Value = "SPRI")]
    [IsoId("_ZOkmYNp-Ed-ak6NoX_4Aeg_723532069")]
    [Description(@"Settlement party is settling its own trades.")]
    SettlingPrincipal = SettlingCapacityCode.SettlingPrincipal, // same ordinal as derivation source for type conversions
    
}
