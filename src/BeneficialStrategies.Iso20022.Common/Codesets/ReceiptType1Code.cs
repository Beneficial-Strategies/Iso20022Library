// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Way of transmitting receipt information to recipient.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MQE3AErHEeenp6hmNprBHg")]
[Description(@"Way of transmitting receipt information to recipient.")]
[DerivedFrom(typeof(ReceiptTypeCode))]
public enum ReceiptType1Code
{
    /// <summary>
    /// Receipt transmitted by Email.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_SvbgEUrHEeenp6hmNprBHg")]
    [Description(@"Receipt transmitted by Email.")]
    EMail = ReceiptTypeCode.EMail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of channel to transmit receipt information to the recipient.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_S7lFskrHEeenp6hmNprBHg")]
    [Description(@"Other type of channel to transmit receipt information to the recipient.")]
    Other = ReceiptTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receipt in a paper form.
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_TKaL4krHEeenp6hmNprBHg")]
    [Description(@"Receipt in a paper form.")]
    Paper = ReceiptTypeCode.Paper, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receipt transmitted by SMS message.
    /// Encoded/decoded by serializers as &quot;SMSM&quot;.
    /// </summary>
    [EnumMember(Value = "SMSM")]
    [IsoId("_TV5DIkrHEeenp6hmNprBHg")]
    [Description(@"Receipt transmitted by SMS message.")]
    SMS = ReceiptTypeCode.SMS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receipt transmitted to a Uniform Resource Identifier (URI) address.
    /// Encoded/decoded by serializers as &quot;URID&quot;.
    /// </summary>
    [EnumMember(Value = "URID")]
    [IsoId("_TnSVIkrHEeenp6hmNprBHg")]
    [Description(@"Receipt transmitted to a Uniform Resource Identifier (URI) address.")]
    UniformResourceIdentifier = ReceiptTypeCode.UniformResourceIdentifier, // same ordinal as derivation source for type conversions
}
