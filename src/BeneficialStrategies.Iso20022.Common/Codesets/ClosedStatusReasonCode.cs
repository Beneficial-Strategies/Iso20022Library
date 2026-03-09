// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the closed status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tYawoE_vEeaB8-OWTiMVrQ")]
[Description(@"Specifies the reason for the closed status.")]
[Derivations(typeof(ClosedStatusReason1Code))]
public enum ClosedStatusReasonCode
{
    /// <summary>
    /// Account is closed, following an instruction from the client, or an authorised party, to close the account.
    /// Encoded/decoded by serializers as &quot;CLIN&quot;.
    /// </summary>
    [EnumMember(Value = "CLIN")]
    [IsoId("_zbGEwE_vEeaB8-OWTiMVrQ")]
    [Description(@"Account is closed, following an instruction from the client, or an authorised party, to close the account.")]
    ClientInstruction,
    
    /// <summary>
    /// Account is closed, following an instruction from the account servicer to close the account.
    /// Encoded/decoded by serializers as &quot;ASIN&quot;.
    /// </summary>
    [EnumMember(Value = "ASIN")]
    [IsoId("_DB_hIE_wEeaB8-OWTiMVrQ")]
    [Description(@"Account is closed, following an instruction from the account servicer to close the account.")]
    AccountServicerInstruction,
    
}
