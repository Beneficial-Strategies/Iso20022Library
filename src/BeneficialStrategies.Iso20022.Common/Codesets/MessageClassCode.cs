// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies a class of messages with the same high level function.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yUpw0Bs_EeqrvK3udMUsNQ")]
[Description(@"Identifies a class of messages with the same high level function.")]
[Derivations(typeof(MessageClass1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageClassCode>))]
#endif
public enum MessageClassCode
{
    /// <summary>
    /// Addendum class of messages.
    /// Encoded/decoded by serializers as &quot;ADDE&quot;.
    /// </summary>
    [EnumMember(Value = "ADDE")]
    [IsoId("_5ZRNoBtAEeqrvK3udMUsNQ")]
    [Description(@"Addendum class of messages.")]
    Addendum,

    /// <summary>
    /// Amendment class of messages.
    /// Encoded/decoded by serializers as &quot;AMDT&quot;.
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_EOQaMBtBEeqrvK3udMUsNQ")]
    [Description(@"Amendment class of messages.")]
    Amendment,

    /// <summary>
    /// Authorisation class of messages.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_OBMT4BtBEeqrvK3udMUsNQ")]
    [Description(@"Authorisation class of messages.")]
    Authorisation,

    /// <summary>
    /// Card management class of messages.
    /// Encoded/decoded by serializers as &quot;CMGT&quot;.
    /// </summary>
    [EnumMember(Value = "CMGT")]
    [IsoId("_d8JUsBtBEeqrvK3udMUsNQ")]
    [Description(@"Card management class of messages.")]
    CardManagement,

    /// <summary>
    /// Charge back class of messages.
    /// Encoded/decoded by serializers as &quot;CBCK&quot;.
    /// </summary>
    [EnumMember(Value = "CBCK")]
    [IsoId("_okyuYBtBEeqrvK3udMUsNQ")]
    [Description(@"Charge back class of messages.")]
    ChargeBack,

    /// <summary>
    /// Fee collection class of messages.
    /// Encoded/decoded by serializers as &quot;FEEC&quot;.
    /// </summary>
    [EnumMember(Value = "FEEC")]
    [IsoId("_vc3ZcBtBEeqrvK3udMUsNQ")]
    [Description(@"Fee collection class of messages.")]
    FeeCollection,

    /// <summary>
    /// Financial class of messages.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_3EZLgBtBEeqrvK3udMUsNQ")]
    [Description(@"Financial class of messages.")]
    Financial,

    /// <summary>
    /// Inquiry class of messages.
    /// Encoded/decoded by serializers as &quot;INQY&quot;.
    /// </summary>
    [EnumMember(Value = "INQY")]
    [IsoId("_8m6_8BtBEeqrvK3udMUsNQ")]
    [Description(@"Inquiry class of messages.")]
    Inquiry,

    /// <summary>
    /// Verification class of messages.
    /// Encoded/decoded by serializers as &quot;VERI&quot;.
    /// </summary>
    [EnumMember(Value = "VERI")]
    [IsoId("_BKOMABtCEeqrvK3udMUsNQ")]
    [Description(@"Verification class of messages.")]
    Verification,
}
