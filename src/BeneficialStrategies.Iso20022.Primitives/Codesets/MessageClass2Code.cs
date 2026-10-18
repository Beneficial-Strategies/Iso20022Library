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
[IsoId("_yAHa4WvbEfCyxsm1jzUNug")]
[Description(@"Identifies a class of messages with the same high level function.")]
[DerivedFrom(typeof(MessageClassCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<MessageClass2Code>))]
public enum MessageClass2Code
{
    /// <summary>
    /// Addendum class of messages.
    /// Encoded/decoded by serializers as &quot;ADDE&quot;.
    /// </summary>
    [EnumMember(Value = "ADDE")]
    [IsoId("_yCYrwWvbEfCyxsm1jzUNug")]
    [Description(@"Addendum class of messages.")]
    Addendum = MessageClassCode.Addendum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amendment class of messages.
    /// Encoded/decoded by serializers as &quot;AMDT&quot;.
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_yCYrw2vbEfCyxsm1jzUNug")]
    [Description(@"Amendment class of messages.")]
    Amendment = MessageClassCode.Amendment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authorisation class of messages.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_yCYrxWvbEfCyxsm1jzUNug")]
    [Description(@"Authorisation class of messages.")]
    Authorisation = MessageClassCode.Authorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge back class of messages.
    /// Encoded/decoded by serializers as &quot;CBCK&quot;.
    /// </summary>
    [EnumMember(Value = "CBCK")]
    [IsoId("_yCYryWvbEfCyxsm1jzUNug")]
    [Description(@"Charge back class of messages.")]
    ChargeBack = MessageClassCode.ChargeBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card management class of messages.
    /// Encoded/decoded by serializers as &quot;CMGT&quot;.
    /// </summary>
    [EnumMember(Value = "CMGT")]
    [IsoId("_yCYrx2vbEfCyxsm1jzUNug")]
    [Description(@"Card management class of messages.")]
    CardManagement = MessageClassCode.CardManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee collection class of messages.
    /// Encoded/decoded by serializers as &quot;FEEC&quot;.
    /// </summary>
    [EnumMember(Value = "FEEC")]
    [IsoId("_yCYry2vbEfCyxsm1jzUNug")]
    [Description(@"Fee collection class of messages.")]
    FeeCollection = MessageClassCode.FeeCollection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial class of messages.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_yCYrzWvbEfCyxsm1jzUNug")]
    [Description(@"Financial class of messages.")]
    Financial = MessageClassCode.Financial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inquiry verification class of messages.
    /// Encoded/decoded by serializers as &quot;INVR&quot;.
    /// </summary>
    [EnumMember(Value = "INVR")]
    [IsoId("_yCYrz2vbEfCyxsm1jzUNug")]
    [Description(@"Inquiry verification class of messages")]
    InquiryVerification = MessageClassCode.InquiryVerification, // same ordinal as derivation source for type conversions
}
