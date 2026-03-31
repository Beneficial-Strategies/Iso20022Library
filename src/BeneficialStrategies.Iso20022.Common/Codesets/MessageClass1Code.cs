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
[IsoId("_IEYhwBtCEeqrvK3udMUsNQ")]
[Description(@"Identifies a class of messages with the same high level function.")]
[DerivedFrom(typeof(MessageClassCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageClass1Code>))]
#endif
public enum MessageClass1Code
{
    /// <summary>
    /// Addendum class of messages.
    /// Encoded/decoded by serializers as &quot;ADDE&quot;.
    /// </summary>
    [EnumMember(Value = "ADDE")]
    [IsoId("_MJCC8RtCEeqrvK3udMUsNQ")]
    [Description(@"Addendum class of messages.")]
    Addendum = MessageClassCode.Addendum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amendment class of messages.
    /// Encoded/decoded by serializers as &quot;AMDT&quot;.
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_MUMKERtCEeqrvK3udMUsNQ")]
    [Description(@"Amendment class of messages.")]
    Amendment = MessageClassCode.Amendment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authorisation class of messages.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_Mfy9IRtCEeqrvK3udMUsNQ")]
    [Description(@"Authorisation class of messages.")]
    Authorisation = MessageClassCode.Authorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card management class of messages.
    /// Encoded/decoded by serializers as &quot;CMGT&quot;.
    /// </summary>
    [EnumMember(Value = "CMGT")]
    [IsoId("_M3wKIRtCEeqrvK3udMUsNQ")]
    [Description(@"Card management class of messages.")]
    CardManagement = MessageClassCode.CardManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge back class of messages.
    /// Encoded/decoded by serializers as &quot;CBCK&quot;.
    /// </summary>
    [EnumMember(Value = "CBCK")]
    [IsoId("_NDgHIRtCEeqrvK3udMUsNQ")]
    [Description(@"Charge back class of messages.")]
    ChargeBack = MessageClassCode.ChargeBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee collection class of messages.
    /// Encoded/decoded by serializers as &quot;FEEC&quot;.
    /// </summary>
    [EnumMember(Value = "FEEC")]
    [IsoId("_NJmvIRtCEeqrvK3udMUsNQ")]
    [Description(@"Fee collection class of messages.")]
    FeeCollection = MessageClassCode.FeeCollection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial class of messages.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_NPQrMRtCEeqrvK3udMUsNQ")]
    [Description(@"Financial class of messages.")]
    Financial = MessageClassCode.Financial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inquiry class of messages.
    /// Encoded/decoded by serializers as &quot;INQY&quot;.
    /// </summary>
    [EnumMember(Value = "INQY")]
    [IsoId("_NbTjIRtCEeqrvK3udMUsNQ")]
    [Description(@"Inquiry class of messages.")]
    Inquiry = MessageClassCode.Inquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification class of messages.
    /// Encoded/decoded by serializers as &quot;VERI&quot;.
    /// </summary>
    [EnumMember(Value = "VERI")]
    [IsoId("_NjCi0RtCEeqrvK3udMUsNQ")]
    [Description(@"Verification class of messages.")]
    Verification = MessageClassCode.Verification, // same ordinal as derivation source for type conversions
}
