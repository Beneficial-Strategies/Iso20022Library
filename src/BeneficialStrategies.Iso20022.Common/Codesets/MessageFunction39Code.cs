// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7NuDMcsZEeizUq4cFQ71-Q")]
[Description(@"Identifies the type of process related to the message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction39Code
{
    /// <summary>
    /// Notification of a rejected message.
    /// Encoded/decoded by serializers as &quot;RENO&quot;.
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("_XATzEPGrEeiGNursv3uE_g")]
    [Description(@"Notification of a rejected message.")]
    RejectNotification = MessageFunctionCode.RejectNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification of a message containing errors.
    /// Encoded/decoded by serializers as &quot;ERNO&quot;.
    /// </summary>
    [EnumMember(Value = "ERNO")]
    [IsoId("_XF6r0fGrEeiGNursv3uE_g")]
    [Description(@"Notification of a message containing errors.")]
    ErrorNotification = MessageFunctionCode.ErrorNotification, // same ordinal as derivation source for type conversions
}
