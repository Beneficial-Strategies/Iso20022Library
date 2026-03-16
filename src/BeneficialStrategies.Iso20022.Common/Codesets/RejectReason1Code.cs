// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason of transmission of a rejection message in response to a request or an advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TT2bOAEcEeCQm6a_G2yO_w_-1578182906")]
[Description(
    @"Reason of transmission of a rejection message in response to a request or an advice."
)]
[DerivedFrom(typeof(RejectReasonCode))]
public enum RejectReason1Code
{
    /// <summary>
    /// Not possible to process the message, for instance the security module is unavailable, the hardware is unavailable, or there is a problem of resource.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_TT2bOQEcEeCQm6a_G2yO_w_-1621972357")]
    [Description(
        @"Not possible to process the message, for instance the security module is unavailable, the hardware is unavailable, or there is a problem of resource."
    )]
    UnableToProcess = RejectReasonCode.UnableToProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid envelope of the message.
    /// Encoded/decoded by serializers as &quot;IMSG&quot;.
    /// </summary>
    [EnumMember(Value = "IMSG")]
    [IsoId("_TT2bOgEcEeCQm6a_G2yO_w_1789761652")]
    [Description(@"Invalid envelope of the message.")]
    InvalidMessage = RejectReasonCode.InvalidMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid message: At least one of the data element or data structure is not present, the format, or the content of one data element or one data structure is not correct.
    /// Encoded/decoded by serializers as &quot;PARS&quot;.
    /// </summary>
    [EnumMember(Value = "PARS")]
    [IsoId("_TT2bOwEcEeCQm6a_G2yO_w_-791442177")]
    [Description(
        @"Invalid message: At least one of the data element or data structure is not present, the format, or the content of one data element or one data structure is not correct."
    )]
    ParsingError = RejectReasonCode.ParsingError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security error (for example an invalid key or an incorrect MAC value).
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_TT2bPAEcEeCQm6a_G2yO_w_1105094547")]
    [Description(@"Security error (for example an invalid key or an incorrect MAC value).")]
    Security = RejectReasonCode.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid identification data for the sender.
    /// Encoded/decoded by serializers as &quot;INTP&quot;.
    /// </summary>
    [EnumMember(Value = "INTP")]
    [IsoId("_TT2bPQEcEeCQm6a_G2yO_w_-1252647576")]
    [Description(@"Invalid identification data for the sender.")]
    InitiatingParty = RejectReasonCode.InitiatingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid identification data for the the receiver.
    /// Encoded/decoded by serializers as &quot;RCPP&quot;.
    /// </summary>
    [EnumMember(Value = "RCPP")]
    [IsoId("_TT2bPgEcEeCQm6a_G2yO_w_1093995770")]
    [Description(@"Invalid identification data for the the receiver.")]
    RecipientParty = RejectReasonCode.RecipientParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duplicate message, the identification of the exchange is the same than a previous message.
    /// Encoded/decoded by serializers as &quot;DPMG&quot;.
    /// </summary>
    [EnumMember(Value = "DPMG")]
    [IsoId("_TT2bPwEcEeCQm6a_G2yO_w_-1263746353")]
    [Description(
        @"Duplicate message, the identification of the exchange is the same than a previous message."
    )]
    DuplicateMessage = RejectReasonCode.DuplicateMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Version of the protocol couldn&apos;t be supported by the recipient.
    /// Encoded/decoded by serializers as &quot;VERS&quot;.
    /// </summary>
    [EnumMember(Value = "VERS")]
    [IsoId("_TT2bQAEcEeCQm6a_G2yO_w_-598184427")]
    [Description(@"Version of the protocol couldn't be supported by the recipient.")]
    ProtocolVersion = RejectReasonCode.ProtocolVersion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of message the recipient receives is unknow or unsupported.
    /// Encoded/decoded by serializers as &quot;MSGT&quot;.
    /// </summary>
    [EnumMember(Value = "MSGT")]
    [IsoId("_TT2bQQEcEeCQm6a_G2yO_w_1339040746")]
    [Description(@"Type of message the recipient receives is unknow or unsupported.")]
    MessageType = RejectReasonCode.MessageType, // same ordinal as derivation source for type conversions
}
