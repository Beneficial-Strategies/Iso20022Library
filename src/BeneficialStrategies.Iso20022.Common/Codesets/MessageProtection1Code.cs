// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Mechanism used to protect the message of the ATM protocol.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JUfXEIrgEeSvuOJS0mmL0g")]
[Description(@"Mechanism used to protect the message of the ATM protocol.")]
[DerivedFrom(typeof(MessageProtectionCode))]
public enum MessageProtection1Code
{
    /// <summary>
    /// Messages contain an encrypted body and a MAC or a digital signature computed on the complete message (header plus body after encryption).
    /// Encoded/decoded by serializers as &quot;EVLP&quot;.
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_L8IuwYrgEeSvuOJS0mmL0g")]
    [Description(
        @"Messages contain an encrypted body and a MAC or a digital signature computed on the complete message (header plus body after encryption)."
    )]
    EnvelopedMessage = MessageProtectionCode.EnvelopedMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Messages contain a MAC or a digital signature computed on the body only.
    /// Encoded/decoded by serializers as &quot;MACB&quot;.
    /// </summary>
    [EnumMember(Value = "MACB")]
    [IsoId("_MBfv4YrgEeSvuOJS0mmL0g")]
    [Description(@"Messages contain a MAC or a digital signature computed on the body only.")]
    MACBody = MessageProtectionCode.MACBody, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Messages contain a MAC or a digital signature computed on the complete message (header plus body).
    /// Encoded/decoded by serializers as &quot;MACM&quot;.
    /// </summary>
    [EnumMember(Value = "MACM")]
    [IsoId("_MHUEA4rgEeSvuOJS0mmL0g")]
    [Description(
        @"Messages contain a MAC or a digital signature computed on the complete message (header plus body)."
    )]
    MACMessage = MessageProtectionCode.MACMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Messages are not protected, no encryption and no MAC or digital signature.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_MLxtQYrgEeSvuOJS0mmL0g")]
    [Description(@"Messages are not protected, no encryption and no MAC or digital signature.")]
    NoProtection = MessageProtectionCode.NoProtection, // same ordinal as derivation source for type conversions
}
