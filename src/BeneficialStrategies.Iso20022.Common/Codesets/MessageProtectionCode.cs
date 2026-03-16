// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Mechanism used to protect the message of the ATM protocol.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5Id0YIrfEeSvuOJS0mmL0g")]
[Description(@"Mechanism used to protect the message of the ATM protocol.")]
[Derivations(typeof(MessageProtection1Code))]
public enum MessageProtectionCode
{
    /// <summary>
    /// Messages contain an encrypted body and a MAC or a digital signature computed on the complete message (header plus body after encryption).
    /// Encoded/decoded by serializers as &quot;EVLP&quot;.
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_8CumEIrfEeSvuOJS0mmL0g")]
    [Description(
        @"Messages contain an encrypted body and a MAC or a digital signature computed on the complete message (header plus body after encryption)."
    )]
    EnvelopedMessage,

    /// <summary>
    /// Messages contain a MAC or a digital signature computed on the body only.
    /// Encoded/decoded by serializers as &quot;MACB&quot;.
    /// </summary>
    [EnumMember(Value = "MACB")]
    [IsoId("__NiVMIrfEeSvuOJS0mmL0g")]
    [Description(@"Messages contain a MAC or a digital signature computed on the body only.")]
    MACBody,

    /// <summary>
    /// Messages contain a MAC or a digital signature computed on the complete message (header plus body).
    /// Encoded/decoded by serializers as &quot;MACM&quot;.
    /// </summary>
    [EnumMember(Value = "MACM")]
    [IsoId("_B1oY0IrgEeSvuOJS0mmL0g")]
    [Description(
        @"Messages contain a MAC or a digital signature computed on the complete message (header plus body)."
    )]
    MACMessage,

    /// <summary>
    /// Messages are not protected, no encryption and no MAC or digital signature.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_EaI88IrgEeSvuOJS0mmL0g")]
    [Description(@"Messages are not protected, no encryption and no MAC or digital signature.")]
    NoProtection,
}
