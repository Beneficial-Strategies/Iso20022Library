// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information related to the protocol management.
/// ISO 8583 MTI.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qIPhcFW7EeeiG_nL4vgKnQ")]
[Description(@"Information related to the protocol management.|ISO 8583 MTI.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction27Code
{
    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_oPgJAemrEemNVKPwszFC-A")]
    [Description(@"Information about the transaction.")]
    Notification = MessageFunctionCode.Notification, // same ordinal as derivation source for type conversions
    
}
