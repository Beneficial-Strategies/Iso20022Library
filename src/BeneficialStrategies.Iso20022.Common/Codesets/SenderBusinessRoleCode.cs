// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether account owner or account servicer sends the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XOtxgFV0Eea1MPROA61PoQ")]
[Description(@"Specifies whether account owner or account servicer sends the message.")]
[Derivations(typeof(SenderBusinessRole1Code))]
public enum SenderBusinessRoleCode
{
    /// <summary>
    /// Sender is the owner of the safekeeping account. The sender is disclosing the breakdown of the underlying owners of sender’s holdings with the receiver.
    /// Encoded/decoded by serializers as &quot;AOWN&quot;.
    /// </summary>
    [EnumMember(Value = "AOWN")]
    [IsoId("_fPi0YFV0Eea1MPROA61PoQ")]
    [Description(@"Sender is the owner of the safekeeping account. The sender is disclosing the breakdown of the underlying owners of sender’s holdings with the receiver.")]
    AccountOwner,
    
    /// <summary>
    /// Sender is the account servicer of an account owned by the receiver.
    /// Encoded/decoded by serializers as &quot;ASER&quot;.
    /// </summary>
    [EnumMember(Value = "ASER")]
    [IsoId("_j6b2MFV0Eea1MPROA61PoQ")]
    [Description(@"Sender is the account servicer of an account owned by the receiver.")]
    AccountServicer,
    
}
