// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the level of response requested from the receiver of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZVH6Udp-Ed-ak6NoX_4Aeg_-1599595783")]
[Description(@"Specifies the level of response requested from the receiver of the message.")]
[DerivedFrom(typeof(ResponseLevelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ResponseLevel1Code>))]
#endif
public enum ResponseLevel1Code
{
    /// <summary>
    /// No acknowledgement is requested.
    /// Encoded/decoded by serializers as &quot;NACK&quot;.
    /// </summary>
    [EnumMember(Value = "NACK")]
    [IsoId("_ZVH6Utp-Ed-ak6NoX_4Aeg_-1557115638")]
    [Description(@"No acknowledgement is requested.")]
    NoAcknowledgement = ResponseLevelCode.NoAcknowledgement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgement of only negative or erroneous messages is requested.
    /// Encoded/decoded by serializers as &quot;ACNE&quot;.
    /// </summary>
    [EnumMember(Value = "ACNE")]
    [IsoId("_ZVH6U9p-Ed-ak6NoX_4Aeg_-1557115330")]
    [Description(@"Acknowledgement of only negative or erroneous messages is requested.")]
    AcknowledgementNegativeError = ResponseLevelCode.AcknowledgementNegativeError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgement of each message is requested.
    /// Encoded/decoded by serializers as &quot;ACEA&quot;.
    /// </summary>
    [EnumMember(Value = "ACEA")]
    [IsoId("_ZVH6VNp-Ed-ak6NoX_4Aeg_-1557115288")]
    [Description(@"Acknowledgement of each message is requested.")]
    AcknowledgementEach = ResponseLevelCode.AcknowledgementEach, // same ordinal as derivation source for type conversions
}
