// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer or settlement instruction status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ygeS8CY-EeW_ZNn8gbfY7Q")]
[Description(@"Specifies the transfer or settlement instruction status.")]
[DerivedFrom(typeof(TransferStatusCode))]
public enum TransferStatus4Code
{
    /// <summary>
    /// Transfer or settlement instruction has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_3USnQSY-EeW_ZNn8gbfY7Q")]
    [Description(@"Transfer or settlement instruction has been acknowledged / accepted for further processing.")]
    Accepted = TransferStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer or settlement instruction is fully executed and the confirmation is sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_3kg0kSY-EeW_ZNn8gbfY7Q")]
    [Description(@"Transfer or settlement instruction is fully executed and the confirmation is sent.")]
    AlreadyExecuted = TransferStatusCode.AlreadyExecuted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer or settlement instruction is matched.
    /// Encoded/decoded by serializers as &quot;MACH&quot;.
    /// </summary>
    [EnumMember(Value = "MACH")]
    [IsoId("_3-_xISY-EeW_ZNn8gbfY7Q")]
    [Description(@"Transfer or settlement instruction is matched.")]
    Matched = TransferStatusCode.Matched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_4VKOYSY-EeW_ZNn8gbfY7Q")]
    [Description(@"Instruction has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.")]
    Received = TransferStatusCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer or settlement instruction has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_4taWUSY-EeW_ZNn8gbfY7Q")]
    [Description(@"Transfer or settlement instruction has been sent to the next party, that is, the next intermediary.")]
    SentToNextParty = TransferStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer or settlement instruction is settled.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_5FEBUSY-EeW_ZNn8gbfY7Q")]
    [Description(@"Transfer or settlement instruction is settled.")]
    Settled = TransferStatusCode.Settled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portfolio transfer is complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_5j3dMSY-EeW_ZNn8gbfY7Q")]
    [Description(@"Portfolio transfer is complete.")]
    Complete = TransferStatusCode.Complete, // same ordinal as derivation source for type conversions
    
}
