// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process requested by the host to an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gPu80CycEeWT0qwwEKj7sA")]
[Description(@"Identifies the type of process requested by the host to an ATM.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction8Code
{
    /// <summary>
    /// Provide the ATM counters resettting those that are applicable.
    /// Encoded/decoded by serializers as &quot;BALN&quot;.
    /// </summary>
    [EnumMember(Value = "BALN")]
    [IsoId("_qGK2cSycEeWT0qwwEKj7sA")]
    [Description(@"Provide the ATM counters resettting those that are applicable.")]
    ATMBalance = MessageFunctionCode.ATMBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Global status of the ATM.
    /// Encoded/decoded by serializers as &quot;GSTS&quot;.
    /// </summary>
    [EnumMember(Value = "GSTS")]
    [IsoId("_rsG5gSycEeWT0qwwEKj7sA")]
    [Description(@"Global status of the ATM.")]
    ATMGlobalStatus = MessageFunctionCode.ATMGlobalStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security detailed report.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_uCydASycEeWT0qwwEKj7sA")]
    [Description(@"Security detailed report.")]
    SecurityDetails = MessageFunctionCode.SecurityDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;INQC&quot;.
    /// </summary>
    [EnumMember(Value = "INQC")]
    [IsoId("_vAyWUSycEeWT0qwwEKj7sA")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry = MessageFunctionCode.CountersInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request of a key exchange.
    /// Encoded/decoded by serializers as &quot;KEYQ&quot;.
    /// </summary>
    [EnumMember(Value = "KEYQ")]
    [IsoId("_xK0k8SycEeWT0qwwEKj7sA")]
    [Description(@"Request of a key exchange.")]
    KeyExchangeRequest = MessageFunctionCode.KeyExchangeRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of cryptographic keys.
    /// Encoded/decoded by serializers as &quot;SSTS&quot;.
    /// </summary>
    [EnumMember(Value = "SSTS")]
    [IsoId("_yriw0SycEeWT0qwwEKj7sA")]
    [Description(@"Status of cryptographic keys.")]
    SecurityKeyStatus = MessageFunctionCode.SecurityKeyStatus, // same ordinal as derivation source for type conversions
    
}
