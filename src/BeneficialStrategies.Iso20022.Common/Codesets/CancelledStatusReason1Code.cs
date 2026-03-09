// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0pMUtp-Ed-ak6NoX_4Aeg_689720888")]
[Description(@"Specifies the underlying reason for cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonCode))]
public enum CancelledStatusReason1Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_a0pMU9p-Ed-ak6NoX_4Aeg_689720889")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonCode.CancelledByYourself, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_a0pMVNp-Ed-ak6NoX_4Aeg_689720890")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem = CancelledStatusReasonCode.CancelledBySystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by the agent.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_a0pMVdp-Ed-ak6NoX_4Aeg_689720891")]
    [Description(@"Transaction is cancelled by the agent.")]
    CancelledByAgent = CancelledStatusReasonCode.CancelledByAgent, // same ordinal as derivation source for type conversions
    
}
