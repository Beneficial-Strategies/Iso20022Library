// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of the communication channels used by the cardholder to the acceptor system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUAMOQEcEeCQm6a_G2yO_w_2033954837")]
[Description(
    @"Identifies the type of the communication channels used by the cardholder to the acceptor system."
)]
[DerivedFrom(typeof(TransactionChannelCode))]
public enum TransactionChannel1Code
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_TUAMOgEcEeCQm6a_G2yO_w_421671046")]
    [Description(@"Mail order.")]
    MailOrder = TransactionChannelCode.MailOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Telephone order.
    /// Encoded/decoded by serializers as &quot;TLPH&quot;.
    /// </summary>
    [EnumMember(Value = "TLPH")]
    [IsoId("_TUAMOwEcEeCQm6a_G2yO_w_-391479472")]
    [Description(@"Telephone order.")]
    TelephoneOrder = TransactionChannelCode.TelephoneOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce.
    /// Encoded/decoded by serializers as &quot;ECOM&quot;.
    /// </summary>
    [EnumMember(Value = "ECOM")]
    [IsoId("_TUAMPAEcEeCQm6a_G2yO_w_-106195051")]
    [Description(@"Electronic commerce.")]
    ElectronicCommerce = TransactionChannelCode.ElectronicCommerce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment on television.
    /// Encoded/decoded by serializers as &quot;TVPY&quot;.
    /// </summary>
    [EnumMember(Value = "TVPY")]
    [IsoId("_TUAMPQEcEeCQm6a_G2yO_w_654570102")]
    [Description(@"Payment on television.")]
    TelevisionPayment = TransactionChannelCode.TelevisionPayment, // same ordinal as derivation source for type conversions
}
