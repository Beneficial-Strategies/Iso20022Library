// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list containing a code that identifies the error condition.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uIhSgPGwEeiGNursv3uE_g")]
[Description(@"Code list containing a code that identifies the error condition.")]
[DerivedFrom(typeof(MessageErrorCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageError1Code>))]
#endif
public enum MessageError1Code
{
    /// <summary>
    /// Invalid data element format
    /// Encoded/decoded by serializers as &quot;IDEF&quot;.
    /// </summary>
    [EnumMember(Value = "IDEF")]
    [IsoId("_wQpcofGwEeiGNursv3uE_g")]
    [Description(@"Invalid data element format")]
    InvalidDataElementFormat = MessageErrorCode.InvalidDataElementFormat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid data element length
    /// Encoded/decoded by serializers as &quot;IDEL&quot;.
    /// </summary>
    [EnumMember(Value = "IDEL")]
    [IsoId("_wUmIgfGwEeiGNursv3uE_g")]
    [Description(@"Invalid data element length")]
    InvalidDataElementLength = MessageErrorCode.InvalidDataElementLength, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid data element value
    /// Encoded/decoded by serializers as &quot;IDEV&quot;.
    /// </summary>
    [EnumMember(Value = "IDEV")]
    [IsoId("_wYS8wfGwEeiGNursv3uE_g")]
    [Description(@"Invalid data element value")]
    InvalidDataElementValue = MessageErrorCode.InvalidDataElementValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid message
    /// Encoded/decoded by serializers as &quot;INME&quot;.
    /// </summary>
    [EnumMember(Value = "INME")]
    [IsoId("_wdMD0fGwEeiGNursv3uE_g")]
    [Description(@"Invalid message")]
    InvalidMessage = MessageErrorCode.InvalidMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Message Function
    /// Encoded/decoded by serializers as &quot;INMF&quot;.
    /// </summary>
    [EnumMember(Value = "INMF")]
    [IsoId("_whFFUfGwEeiGNursv3uE_g")]
    [Description(@"Invalid Message Function")]
    InvalidMessageFunction = MessageErrorCode.InvalidMessageFunction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message Parse Error
    /// Encoded/decoded by serializers as &quot;MEPE&quot;.
    /// </summary>
    [EnumMember(Value = "MEPE")]
    [IsoId("_wppLcfGwEeiGNursv3uE_g")]
    [Description(@"Message Parse Error")]
    MessageParseError = MessageErrorCode.MessageParseError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other reason to reject a message defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_wxHFYfGwEeiGNursv3uE_g")]
    [Description(@"Other reason to reject a message defined at private level.")]
    OtherPrivate = MessageErrorCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protocol Version
    /// Encoded/decoded by serializers as &quot;PRVE&quot;.
    /// </summary>
    [EnumMember(Value = "PRVE")]
    [IsoId("_w3BgIfGwEeiGNursv3uE_g")]
    [Description(@"Protocol Version")]
    ProtocolVersion = MessageErrorCode.ProtocolVersion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Required data element missing
    /// Encoded/decoded by serializers as &quot;RDEM&quot;.
    /// </summary>
    [EnumMember(Value = "RDEM")]
    [IsoId("_xA0VUfGwEeiGNursv3uE_g")]
    [Description(@"Required data element missing")]
    RequiredDataElementMissing = MessageErrorCode.RequiredDataElementMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_xF7e0fGwEeiGNursv3uE_g")]
    [Description(@"Security")]
    Security = MessageErrorCode.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Error that is not defined in the Message type Error and is not OtherNational or OtherPrivate Error
    /// Encoded/decoded by serializers as &quot;UDFD&quot;.
    /// </summary>
    [EnumMember(Value = "UDFD")]
    [IsoId("_xLVjQfGwEeiGNursv3uE_g")]
    [Description(
        @"Error that is not defined in the Message type Error and is not OtherNational or OtherPrivate Error "
    )]
    Undefined = MessageErrorCode.Undefined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other reason defined at national level to reject a message.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_xSn3AfGwEeiGNursv3uE_g")]
    [Description(@"Other reason defined at national level to reject a message.")]
    OtherNational = MessageErrorCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Iterative data error
    /// Encoded/decoded by serializers as &quot;ITDE&quot;.
    /// </summary>
    [EnumMember(Value = "ITDE")]
    [IsoId("_xcrx8fGwEeiGNursv3uE_g")]
    [Description(@"Iterative data error")]
    IterativeDataError = MessageErrorCode.IterativeDataError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duplicate Message
    /// Encoded/decoded by serializers as &quot;DUME&quot;.
    /// </summary>
    [EnumMember(Value = "DUME")]
    [IsoId("_yFe3UfGwEeiGNursv3uE_g")]
    [Description(@"Duplicate Message")]
    DuplicateMessage = MessageErrorCode.DuplicateMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inconsistent data within message
    /// Encoded/decoded by serializers as &quot;IDWM&quot;.
    /// </summary>
    [EnumMember(Value = "IDWM")]
    [IsoId("_yJnwcfGwEeiGNursv3uE_g")]
    [Description(@"Inconsistent data within message")]
    InconsistentDataWithinMessage = MessageErrorCode.InconsistentDataWithinMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inconsistent data with related message
    /// Encoded/decoded by serializers as &quot;IDRM&quot;.
    /// </summary>
    [EnumMember(Value = "IDRM")]
    [IsoId("_yNfj0fGwEeiGNursv3uE_g")]
    [Description(@"Inconsistent data with related message")]
    InconsistentDataWithRelatedMessage = MessageErrorCode.InconsistentDataWithRelatedMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Batch
    /// Encoded/decoded by serializers as &quot;IBAT&quot;.
    /// </summary>
    [EnumMember(Value = "IBAT")]
    [IsoId("_yRYlUfGwEeiGNursv3uE_g")]
    [Description(@"Invalid Batch")]
    InvalidBatch = MessageErrorCode.InvalidBatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Collection
    /// Encoded/decoded by serializers as &quot;ICOL&quot;.
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_yWE4EfGwEeiGNursv3uE_g")]
    [Description(@"Invalid Collection")]
    InvalidCollection = MessageErrorCode.InvalidCollection, // same ordinal as derivation source for type conversions
}
