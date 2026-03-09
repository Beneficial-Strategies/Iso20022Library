// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_znHxMOBBEeiVRbNQx5-Vhg")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonCode))]
public enum CancelledStatusReason17Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_8oENQuBBEeiVRbNQx5-Vhg")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonCode.CancelledByYourself, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other (see additional information).
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_zdUNIQiAEeuAafINYd9EUw")]
    [Description(@"Other (see additional information).")]
    Other = CancelledStatusReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by the agent.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_EvmEwSAQEeu0P6yLvKBt0w")]
    [Description(@"Transaction is cancelled by the agent.")]
    CancelledByAgent = CancelledStatusReasonCode.CancelledByAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_IGRssSAQEeu0P6yLvKBt0w")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem = CancelledStatusReasonCode.CancelledBySystem, // same ordinal as derivation source for type conversions
    
}
