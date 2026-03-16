// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list containing a code that identifies the error condition.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iwO2kPGuEeiGNursv3uE_g")]
[Description(@"Code list containing a code that identifies the error condition.")]
[Derivations(typeof(MessageError1Code))]
public enum MessageErrorCode
{
    /// <summary>
    /// Other reason defined at national level to reject a message.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_iwO2n_GuEeiGNursv3uE_g")]
    [Description(@"Other reason defined at national level to reject a message.")]
    OtherNational,

    /// <summary>
    /// Other reason to reject a message defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_iwO2mfGuEeiGNursv3uE_g")]
    [Description(@"Other reason to reject a message defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Required data element missing
    /// Encoded/decoded by serializers as &quot;RDEM&quot;.
    /// </summary>
    [EnumMember(Value = "RDEM")]
    [IsoId("_iwO2l_GuEeiGNursv3uE_g")]
    [Description(@"Required data element missing")]
    RequiredDataElementMissing,

    /// <summary>
    /// Invalid Message Function
    /// Encoded/decoded by serializers as &quot;INMF&quot;.
    /// </summary>
    [EnumMember(Value = "INMF")]
    [IsoId("_iwO2mvGuEeiGNursv3uE_g")]
    [Description(@"Invalid Message Function")]
    InvalidMessageFunction,

    /// <summary>
    /// Invalid Collection
    /// Encoded/decoded by serializers as &quot;ICOL&quot;.
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_iwO2lvGuEeiGNursv3uE_g")]
    [Description(@"Invalid Collection")]
    InvalidCollection,

    /// <summary>
    /// Invalid message
    /// Encoded/decoded by serializers as &quot;INME&quot;.
    /// </summary>
    [EnumMember(Value = "INME")]
    [IsoId("_iwO2nPGuEeiGNursv3uE_g")]
    [Description(@"Invalid message")]
    InvalidMessage,

    /// <summary>
    /// Message Parse Error
    /// Encoded/decoded by serializers as &quot;MEPE&quot;.
    /// </summary>
    [EnumMember(Value = "MEPE")]
    [IsoId("_iwO2lPGuEeiGNursv3uE_g")]
    [Description(@"Message Parse Error")]
    MessageParseError,

    /// <summary>
    /// Protocol Version
    /// Encoded/decoded by serializers as &quot;PRVE&quot;.
    /// </summary>
    [EnumMember(Value = "PRVE")]
    [IsoId("_iwO2nfGuEeiGNursv3uE_g")]
    [Description(@"Protocol Version")]
    ProtocolVersion,

    /// <summary>
    /// Error that is not defined in the Message type Error and is not OtherNational or OtherPrivate Error
    /// Encoded/decoded by serializers as &quot;UDFD&quot;.
    /// </summary>
    [EnumMember(Value = "UDFD")]
    [IsoId("_iwO2m_GuEeiGNursv3uE_g")]
    [Description(
        @"Error that is not defined in the Message type Error and is not OtherNational or OtherPrivate Error "
    )]
    Undefined,

    /// <summary>
    /// Security
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_iwO2nvGuEeiGNursv3uE_g")]
    [Description(@"Security")]
    Security,

    /// <summary>
    /// Duplicate Message
    /// Encoded/decoded by serializers as &quot;DUME&quot;.
    /// </summary>
    [EnumMember(Value = "DUME")]
    [IsoId("_iwO2kfGuEeiGNursv3uE_g")]
    [Description(@"Duplicate Message")]
    DuplicateMessage,

    /// <summary>
    /// Invalid Batch
    /// Encoded/decoded by serializers as &quot;IBAT&quot;.
    /// </summary>
    [EnumMember(Value = "IBAT")]
    [IsoId("_iwO2kvGuEeiGNursv3uE_g")]
    [Description(@"Invalid Batch")]
    InvalidBatch,

    /// <summary>
    /// Invalid data element length
    /// Encoded/decoded by serializers as &quot;IDEL&quot;.
    /// </summary>
    [EnumMember(Value = "IDEL")]
    [IsoId("_4Duz4PGvEeiGNursv3uE_g")]
    [Description(@"Invalid data element length")]
    InvalidDataElementLength,

    /// <summary>
    /// Invalid data element value
    /// Encoded/decoded by serializers as &quot;IDEV&quot;.
    /// </summary>
    [EnumMember(Value = "IDEV")]
    [IsoId("_CP33wPGwEeiGNursv3uE_g")]
    [Description(@"Invalid data element value")]
    InvalidDataElementValue,

    /// <summary>
    /// Invalid data element format
    /// Encoded/decoded by serializers as &quot;IDEF&quot;.
    /// </summary>
    [EnumMember(Value = "IDEF")]
    [IsoId("_GQAsYPGwEeiGNursv3uE_g")]
    [Description(@"Invalid data element format")]
    InvalidDataElementFormat,

    /// <summary>
    /// Inconsistent data within message
    /// Encoded/decoded by serializers as &quot;IDWM&quot;.
    /// </summary>
    [EnumMember(Value = "IDWM")]
    [IsoId("_NQqEoPGwEeiGNursv3uE_g")]
    [Description(@"Inconsistent data within message")]
    InconsistentDataWithinMessage,

    /// <summary>
    /// Inconsistent data with related message
    /// Encoded/decoded by serializers as &quot;IDRM&quot;.
    /// </summary>
    [EnumMember(Value = "IDRM")]
    [IsoId("_S2HRQPGwEeiGNursv3uE_g")]
    [Description(@"Inconsistent data with related message")]
    InconsistentDataWithRelatedMessage,

    /// <summary>
    /// Iterative data error
    /// Encoded/decoded by serializers as &quot;ITDE&quot;.
    /// </summary>
    [EnumMember(Value = "ITDE")]
    [IsoId("_YYnQgPGwEeiGNursv3uE_g")]
    [Description(@"Iterative data error")]
    IterativeDataError,
}
