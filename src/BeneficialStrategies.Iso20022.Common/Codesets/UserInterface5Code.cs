// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Destination of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7Gewga13EeWMg5rOByfExw")]
[Description(@"Destination of the message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UserInterface5Code>))]
#endif
public enum UserInterface5Code
{
    /// <summary>
    /// Cardholder display or interface.
    /// Encoded/decoded by serializers as &quot;CDSP&quot;.
    /// </summary>
    [EnumMember(Value = "CDSP")]
    [IsoId("_7SQisa13EeWMg5rOByfExw")]
    [Description(@"Cardholder display or interface.")]
    CardholderDisplay = UserInterfaceCode.CardholderDisplay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder receipt.
    /// Encoded/decoded by serializers as &quot;CRCP&quot;.
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_7SQis613EeWMg5rOByfExw")]
    [Description(@"Cardholder receipt.")]
    CardholderReceipt = UserInterfaceCode.CardholderReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other interface of the cardholder, for instance e-mail or smartphone message.
    /// Encoded/decoded by serializers as &quot;CRDO&quot;.
    /// </summary>
    [EnumMember(Value = "CRDO")]
    [IsoId("_7SQiua13EeWMg5rOByfExw")]
    [Description(@"Other interface of the cardholder, for instance e-mail or smartphone message.")]
    OtherCardholderInterface = UserInterfaceCode.OtherCardholderInterface, // same ordinal as derivation source for type conversions
}
