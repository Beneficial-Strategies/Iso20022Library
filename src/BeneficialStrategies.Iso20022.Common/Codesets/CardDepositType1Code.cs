// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the type of deposit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_355HIC7TEemIy6A-26wnAg")]
[Description(@"Contains the type of deposit.")]
[DerivedFrom(typeof(CardDepositTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardDepositType1Code>))]
#endif
public enum CardDepositType1Code
{
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6AbV0S7TEemIy6A-26wnAg")]
    [Description(@"Other Private")]
    OtherPrivate = CardDepositTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6EiZwS7TEemIy6A-26wnAg")]
    [Description(@"Other National")]
    OtherNational = CardDepositTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Envelope
    /// Encoded/decoded by serializers as &quot;ENVL&quot;.
    /// </summary>
    [EnumMember(Value = "ENVL")]
    [IsoId("_6JHXwS7TEemIy6A-26wnAg")]
    [Description(@"Envelope")]
    Envelope = CardDepositTypeCode.Envelope, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque
    /// Encoded/decoded by serializers as &quot;CHEC&quot;.
    /// </summary>
    [EnumMember(Value = "CHEC")]
    [IsoId("_6KROUS7TEemIy6A-26wnAg")]
    [Description(@"Cheque")]
    Cheque = CardDepositTypeCode.Cheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_6L8CQS7TEemIy6A-26wnAg")]
    [Description(@"Cash")]
    Cash = CardDepositTypeCode.Cash, // same ordinal as derivation source for type conversions
}
