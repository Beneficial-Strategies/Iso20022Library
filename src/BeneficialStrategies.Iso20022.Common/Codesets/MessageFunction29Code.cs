// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to the message.
/// Fee collection header.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_T3DTEFaGEeeFltjJxERUxw")]
[Description(
    @"Identifies the type of process related to the message.|Fee collection header.|ISO 8583 MTI"
)]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction29Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_fhDAkemqEemNVKPwszFC-A")]
    [Description(
        @"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. "
    )]
    Advice = MessageFunctionCode.Advice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_geC0UemqEemNVKPwszFC-A")]
    [Description(@"Information about the transaction.")]
    Notification = MessageFunctionCode.Notification, // same ordinal as derivation source for type conversions
}
