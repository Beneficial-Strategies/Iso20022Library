// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vp1UUNp-Ed-ak6NoX_4Aeg_358546610")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusCode))]
public enum Status1Code
{
    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_Vp1UUdp-Ed-ak6NoX_4Aeg_-1876044207")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted = StatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_Vp1UUtp-Ed-ak6NoX_4Aeg_-1876043852")]
    [Description(@"Processing has been completed.")]
    Completed = StatusCode.Completed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No instruction has been received (to be used in a reminder).
    /// Encoded/decoded by serializers as &quot;NOIN&quot;.
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_Vp1UU9p-Ed-ak6NoX_4Aeg_-1876043722")]
    [Description(@"No instruction has been received (to be used in a reminder).")]
    NotReceived = StatusCode.NotReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_Vp1UVNp-Ed-ak6NoX_4Aeg_-1876043379")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = StatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been received by Issuer.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_Vp1UVdp-Ed-ak6NoX_4Aeg_-1566097325")]
    [Description(@"Instruction has been received by Issuer.")]
    ReceivedByIssuerOrRegistrar = StatusCode.ReceivedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
    
}
