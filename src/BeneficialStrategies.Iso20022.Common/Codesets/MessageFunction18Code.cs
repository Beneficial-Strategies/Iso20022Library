// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to a batch management.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QRBPYFAWEeedyPuM0kK2EQ")]
[Description(@"Identifies the type of process related to a batch management.|ISO 8583 MTI")]
[DerivedFrom(typeof(MessageFunctionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageFunction18Code>))]
#endif
public enum MessageFunction18Code
{
    /// <summary>
    /// Request to initiate the transfer of a batch (response expected).
    /// Encoded/decoded by serializers as &quot;BTRQ&quot;.
    /// </summary>
    [EnumMember(Value = "BTRQ")]
    [IsoId("_cAK-IVAWEeedyPuM0kK2EQ")]
    [Description(@"Request to initiate the transfer of a batch (response expected).")]
    BatchRequest = MessageFunctionCode.BatchRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification to initiate the transfer of a batch (no response expected).
    /// Encoded/decoded by serializers as &quot;BTNF&quot;.
    /// </summary>
    [EnumMember(Value = "BTNF")]
    [IsoId("_cOdRwlAWEeedyPuM0kK2EQ")]
    [Description(@"Notification to initiate the transfer of a batch (no response expected).")]
    BatchNotification = MessageFunctionCode.BatchNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification to initiate the transfer of a collection (no response expected).
    /// Encoded/decoded by serializers as &quot;CLNF&quot;.
    /// </summary>
    [EnumMember(Value = "CLNF")]
    [IsoId("_cgdAslAWEeedyPuM0kK2EQ")]
    [Description(@"Notification to initiate the transfer of a collection (no response expected).")]
    CollectionNotification = MessageFunctionCode.CollectionNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to initiate the transfer of a collection (response expected).
    /// Encoded/decoded by serializers as &quot;CLRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CLRQ")]
    [IsoId("_cyAqwlAWEeedyPuM0kK2EQ")]
    [Description(@"Request to initiate the transfer of a collection (response expected).")]
    CollectionRequest = MessageFunctionCode.CollectionRequest, // same ordinal as derivation source for type conversions
}
