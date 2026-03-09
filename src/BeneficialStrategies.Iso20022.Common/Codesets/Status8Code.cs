// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a status of an instruction/vote.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Tmb0Aa-nEemJ1NnLPsTFaw")]
[Description(@"Specifies a status of an instruction/vote.")]
[DerivedFrom(typeof(StatusCode))]
public enum Status8Code
{
    /// <summary>
    /// Instruction has been cancelled by the agent, for example, due to an event deadline extension.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_T6q-oa-nEemJ1NnLPsTFaw")]
    [Description(@"Instruction has been cancelled by the agent, for example, due to an event deadline extension.")]
    CancelledBySubcustodian = StatusCode.CancelledBySubcustodian, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_T6q-o6-nEemJ1NnLPsTFaw")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted = StatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_T6q-pa-nEemJ1NnLPsTFaw")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = StatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been received by Issuer.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_T6q-q6-nEemJ1NnLPsTFaw")]
    [Description(@"Instruction has been received by Issuer.")]
    ReceivedByIssuerOrRegistrar = StatusCode.ReceivedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_T6q-ra-nEemJ1NnLPsTFaw")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction = StatusCode.StandingInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accepted and sent along the chain.
    /// Encoded/decoded by serializers as &quot;FRWD&quot;.
    /// </summary>
    [EnumMember(Value = "FRWD")]
    [IsoId("_OS6H0bUsEem2T48lBgJbww")]
    [Description(@"Accepted and sent along the chain.")]
    Forwarded = StatusCode.Forwarded, // same ordinal as derivation source for type conversions
    
}
