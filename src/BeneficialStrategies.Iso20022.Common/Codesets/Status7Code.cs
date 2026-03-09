// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction/vote.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WMNrgF6uEeSyc4g_pm5hbw")]
[Description(@"Specifies the status of an instruction/vote.")]
[DerivedFrom(typeof(StatusCode))]
public enum Status7Code
{
    /// <summary>
    /// Instruction has been cancelled by the agent, for example, due to an event deadline extension.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_YyZqoF6uEeSyc4g_pm5hbw")]
    [Description(@"Instruction has been cancelled by the agent, for example, due to an event deadline extension.")]
    CancelledBySubcustodian = StatusCode.CancelledBySubcustodian, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aCL3gV6uEeSyc4g_pm5hbw")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted = StatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_agtmkV6uEeSyc4g_pm5hbw")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = StatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_a88PkV6uEeSyc4g_pm5hbw")]
    [Description(@"Processing has been completed.")]
    Completed = StatusCode.Completed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No instruction has been received (to be used in a reminder).
    /// Encoded/decoded by serializers as &quot;NOIN&quot;.
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_b10_YV6uEeSyc4g_pm5hbw")]
    [Description(@"No instruction has been received (to be used in a reminder).")]
    NotReceived = StatusCode.NotReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been received by Issuer.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_c1-00V6uEeSyc4g_pm5hbw")]
    [Description(@"Instruction has been received by Issuer.")]
    ReceivedByIssuerOrRegistrar = StatusCode.ReceivedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_dTZJkV6uEeSyc4g_pm5hbw")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction = StatusCode.StandingInstruction, // same ordinal as derivation source for type conversions
    
}
